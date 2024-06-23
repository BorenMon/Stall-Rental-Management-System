using Stall_Rental_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Helpers.NavigateHelpers;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Services;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;

namespace Stall_Rental_Management_System.Presenters
{
    public class StaffPresenter
    {
        // Fields
        private readonly FrmStaff _view;
        private readonly StaffRepository _repository;
        private readonly BindingSource _staffsBindingSource;
        private IEnumerable<StaffModel> _staffList;
        
        private readonly AuthenticationService _authService;

        // Constructor
        public StaffPresenter(FrmStaff view, StaffRepository repository, AuthenticationService authService)
        {
            _staffsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;
            _authService = authService;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStaff;
            _view.UploadProfileEvent += UploadStaffProfile;
            _view.AddNewEvent += AddNewStaff;
            _view.DeleteEvent += DeleteSelectedStaff;
            _view.SaveOrUpdateEvent += SaveOrUpdateStaff;
            _view.BackToPanelEvent += BackToPanel;
            _view.ViewEvent += ViewStaff;

            // Set staffs binding source
            _view.SetStaffListBindingSource(_staffsBindingSource);

            // Load staff list view
            LoadAllStaffList();
        }

        private async void UploadStaffProfile(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                var selectedFileName = openFileDialog.FileName;

                // Compress the image before uploading
                var compressedFileStream = ImageHelper.CompressImage(selectedFileName);

                var objectName = "profile/" + MinIoUtil.GenerateRandomObjectName("staff_profile", 15);
                var contentType = MinIoUtil.GetContentType(selectedFileName);
                const string bucketName = "srms";

                MinIoUtil.InitMinioClient();
                await MinIoUtil.UploadFileAsync(objectName, compressedFileStream, contentType, bucketName);

                _view.CurrentProfileImageObjectName = objectName;
                _view.ProfileImageUrl = objectName;
            }
        }

        private void ViewStaff(object sender, EventArgs e)
        {
            _view.IsEdit = true;
            LoadSelectedStaff();
        }

        private void BackToPanel(object sender, EventArgs e)
        {
            var currentUser = CurrentUserUtil.User;
            if (currentUser.UserType == UserType.SUPERMARKET_STAFF && currentUser.Position == StaffPosition.MANAGER) 
                ManagerNavigateHelper.NavigateToManagerPanel(_view, _authService);
        }

        private void LoadAllStaffList()
        {
            _staffList = _repository.GetAll();
            _staffsBindingSource.DataSource = _staffList; // Set data source
        }
        private void SearchStaff(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _staffList = emptyValue==false ? _repository.GetByValue(this._view.SearchValue) : _repository.GetAll();
            _staffsBindingSource.DataSource = _staffList;
        }

        private void SaveOrUpdateStaff(object sender, EventArgs e)
        {
            var staff = new StaffModel
            {
                ProfileImageUrl = _view.CurrentProfileImageObjectName,
                LastNameEn = _view.LastNameEn,
                FirstNameEn = _view.FirstNameEn,
                LastNameKh = _view.LastNameKh,
                FirstNameKh = _view.FirstNameKh,
                BirthDate = _view.BirthDate,
                Gender = _view.Gender,
                Email = _view.Email,
                Position = _view.Position,
                PhoneNumber = _view.PhoneNumber,
                Password = _view.Password,
                Address = _view.Address
            };
            try
            {
                ModelDataValidation.Validate(staff);
                if (!int.TryParse(_view.StaffId, out var staffId))
                {
                    staffId = 0; // Set default value if parsing fails
                }
                _repository.InsertOrUpdate(staff, staffId, _view.IsPasswordChanged);
                _view.Message = _view.IsEdit ? "Staff edited successfully" : "Staff added successfully";

                _view.IsSuccessful = true;
                LoadAllStaffList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.StaffId = "Auto Generate";
            _view.CurrentProfileImageObjectName = null;
            _view.ProfileImageUrl = "";
            _view.LastNameEn = null;
            _view.FirstNameEn = null;
            _view.LastNameKh = null;
            _view.FirstNameKh = null;
            _view.BirthDate = DateTime.Now.Date;
            _view.Gender = Gender.FEMALE;
            _view.Email = null;
            _view.Position = StaffPosition.STAFF;
            _view.PhoneNumber = null;
            _view.Password = null;
            _view.Address = null;
        }

        private void DeleteSelectedStaff(object sender, EventArgs e)
        {
            try
            {
                var staff = (StaffModel)_staffsBindingSource.Current;
                _repository.Delete(staff);
                _view.IsSuccessful = true;
                _view.Message = "Staff deleted successfully";
                LoadAllStaffList();
            }
            catch (Exception)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error occured, could not delete staff";
            }
        }

        private void LoadSelectedStaff()
        {
            var staff = (StaffModel)_staffsBindingSource.Current;
        
            _view.StaffId = staff.StaffId.ToString();
            _view.ProfileImageUrl = staff.ProfileImageUrl;
            _view.LastNameKh = staff.LastNameKh;
            _view.FirstNameKh = staff.FirstNameKh;
            _view.LastNameEn = staff.LastNameEn;
            _view.FirstNameEn = staff.FirstNameEn;
            _view.BirthDate = staff.BirthDate;
            _view.Gender = staff.Gender;
            _view.Email = staff.Email;
            _view.Position = staff.Position;
            _view.PhoneNumber = staff.PhoneNumber;
            _view.Password = staff.Password;
            _view.Address = staff.Address;

            _view.IsPasswordChanged = false; // reset the flag after loading the staff details
        }

        private void AddNewStaff(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}
