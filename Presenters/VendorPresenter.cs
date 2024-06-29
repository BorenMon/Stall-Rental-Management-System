using Stall_Rental_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;

namespace Stall_Rental_Management_System.Presenters
{
    public class VendorPresenter
    {
        // Fields
        private readonly FrmVendor _view;
        private readonly VendorRepository _repository;
        private readonly BindingSource _vendorsBindingSource;
        private IEnumerable<VendorModel> _vendorList;

        // Constructor
        public VendorPresenter(FrmVendor view, VendorRepository repository)
        {
            _vendorsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchVendor;
            _view.UploadProfileEvent += UploadVendorProfile;
            _view.AddNewEvent += AddNewVendor;
            _view.DeleteEvent += DeleteSelectedVendor;
            _view.SaveOrUpdateEvent += SaveOrUpdateVendor;
            _view.ViewEvent += ViewVendor;

            // Set vendors binding source
            _view.SetVendorListBindingSource(_vendorsBindingSource);

            // Load vendor list view
            LoadAllVendorList();
        }

        private async void UploadVendorProfile(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                var selectedFileName = openFileDialog.FileName;

                // Compress the image before uploading
                var compressedFileStream = ImageHelper.CompressImage(selectedFileName);

                var objectName = "profile/" + MinIoUtil.GenerateRandomObjectName("vendor_profile", 15);
                var contentType = MinIoUtil.GetContentType(selectedFileName);
                const string bucketName = "srms";

                MinIoUtil.InitMinioClient();
                await MinIoUtil.UploadFileAsync(objectName, compressedFileStream, contentType, bucketName);

                _view.CurrentProfileImageObjectName = objectName;
                _view.ProfileImageUrl = objectName;
            }
        }

        private void ViewVendor(object sender, EventArgs e)
        {
            _view.IsEdit = true;
            LoadSelectedVendor();
        }

        private void LoadAllVendorList()
        {
            _vendorList = _repository.GetAll();
            _vendorsBindingSource.DataSource = _vendorList; // Set data source
        }
        private void SearchVendor(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _vendorList = emptyValue==false ? _repository.GetByValue(this._view.SearchValue) : _repository.GetAll();
            _vendorsBindingSource.DataSource = _vendorList;
        }

        private void SaveOrUpdateVendor(object sender, EventArgs e)
        {
            var vendor = new VendorModel
            {
                ProfileImageUrl = _view.CurrentProfileImageObjectName,
                LastNameEn = _view.LastNameEn,
                FirstNameEn = _view.FirstNameEn,
                LastNameKh = _view.LastNameKh,
                FirstNameKh = _view.FirstNameKh,
                BirthDate = _view.BirthDate,
                Gender = _view.Gender,
                Email = _view.Email,
                PhoneNumber = _view.PhoneNumber,
                Password = _view.Password,
                Address = _view.Address
            };
            try
            {
                ModelDataValidation.Validate(vendor);
                if (!int.TryParse(_view.VendorId, out var vendorId))
                {
                    vendorId = 0; // Set default value if parsing fails
                }
                _repository.InsertOrUpdate(vendor, vendorId, _view.IsPasswordChanged);
                _view.Message = _view.IsEdit ? "Vendor edited successfully" : "Vendor added successfully";

                _view.IsSuccessful = true;
                LoadAllVendorList();
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
            _view.VendorId = "Auto Generate";
            _view.CurrentProfileImageObjectName = null;
            _view.ProfileImageUrl = "";
            _view.LastNameEn = null;
            _view.FirstNameEn = null;
            _view.LastNameKh = null;
            _view.FirstNameKh = null;
            _view.BirthDate = DateTime.Now.Date;
            _view.Gender = Gender.FEMALE;
            _view.Email = null;
            _view.PhoneNumber = null;
            _view.Password = null;
            _view.Address = null;
        }

        private void DeleteSelectedVendor(object sender, EventArgs e)
        {
            try
            {
                var vendor = (VendorModel)_vendorsBindingSource.Current;
                _repository.Delete(vendor);
                _view.IsSuccessful = true;
                _view.Message = "Vendor deleted successfully";
                LoadAllVendorList();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void LoadSelectedVendor()
        {
            var vendor = (VendorModel)_vendorsBindingSource.Current;
        
            _view.VendorId = vendor.VendorId.ToString();
            _view.ProfileImageUrl = vendor.ProfileImageUrl;
            _view.LastNameKh = vendor.LastNameKh;
            _view.FirstNameKh = vendor.FirstNameKh;
            _view.LastNameEn = vendor.LastNameEn;
            _view.FirstNameEn = vendor.FirstNameEn;
            _view.BirthDate = vendor.BirthDate;
            _view.Gender = vendor.Gender;
            _view.Email = vendor.Email;
            _view.PhoneNumber = vendor.PhoneNumber;
            _view.Password = vendor.Password;
            _view.Address = vendor.Address;

            _view.IsPasswordChanged = false; // reset the flag after loading the staff details
        }

        private void AddNewVendor(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}
