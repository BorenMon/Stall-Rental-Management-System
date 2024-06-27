using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Models;
using System.IO;
using Stall_Rental_Management_System.Helpers;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Presenters
{
    public class StallPresenter
    {
        // Fields
        private readonly FrmStall _view;
        private readonly StallRepository _repository;
        private readonly BindingSource _stallsBindingSource;
        private IEnumerable<StallModel> _stallList;

        // Constructor
        public StallPresenter(FrmStall view, StallRepository repository)
        {
            _stallsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStall;
            _view.AddNewEvent += AddNewStall;
            _view.DeleteEvent += DeleteSelectedStall;
            _view.SaveOrUpdateEvent += SaveOrUpdateStall;
            _view.ViewEvent += ViewStall;
            _view.AddImageButton.Click += OnAddImage;
            _view.RemoveImageButton.Click += OnRemoveImage;
            _view.ImageListBox.SelectedIndexChanged += OnImageSelected;

            // Set staffs binding source
            _view.SetStallListBindingSource(_stallsBindingSource);

            // Load staff list view
            LoadAllStalls();
        }

        public void LoadImages(int stallId)
        {
            var images = _repository.GetImagesByStallId(stallId);
            _view.ImageListBox.DataSource = images;
            _view.ImageListBox.DisplayMember = "FileName";
            if (images != null) { _view.ImagePictureBox.ImageLocation = null; } 
        }

        private async void OnAddImage(object sender, EventArgs e)
        {
            if (_view.OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                var selectedFileName = _view.OpenFileDialog.FileName;

                // Compress the image before uploading
                var compressedFileStream = ImageHelper.CompressImage(selectedFileName);

                var fileName = MinIoUtil.GenerateRandomObjectName("stall_image", 15);
                var objectName = "stall/" + fileName;
                var contentType = MinIoUtil.GetContentType(selectedFileName);
                const string bucketName = "srms";

                MinIoUtil.InitMinioClient();
                await MinIoUtil.UploadFileAsync(objectName, compressedFileStream, contentType, bucketName);

                var url = objectName;
                var image = new StallImageModel { URL = url, FileName = fileName, StallID = _view.StallId };
                _repository.AddImage(image);
                LoadImages(_view.StallId);
            }
        }

        private void OnRemoveImage(object sender, EventArgs e)
        {
            if (_view.ImageListBox.SelectedItem is StallImageModel selectedImage)
            {
                _repository.RemoveImage(selectedImage.StallImageID);
                LoadImages(_view.StallId); // Refresh the image list
            }
        }

        private void OnImageSelected(object sender, EventArgs e)
        {
            if (_view.ImageListBox.SelectedItem is StallImageModel selectedImage)
            {
                _view.ImagePictureBox.ImageLocation = MinIoUtil.GenerateFileUrl(selectedImage.URL, "srms");
            }
        }

        private void ViewStall(object sender, EventArgs e)
        {
            _view.IsEdit = true;
            LoadSelectedStall();
        }

        private void LoadAllStalls()
        {
            _stallList = _repository.GetAll();
            _stallsBindingSource.DataSource = _stallList; // Set data source
        }
        
        private void SearchStall(object sender, EventArgs e)
        {
            var emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            _stallList = emptyValue==false ? _repository.GetByCode(this._view.SearchValue) : _repository.GetAll();
            _stallsBindingSource.DataSource = _stallList;
        }

        private void SaveOrUpdateStall(object sender, EventArgs e)
        {
            var stall = new StallModel
            {
                Code = _view.Code,
                Status = _view.Status,
                Type = _view.Type,
                Size = _view.StallSize,
                MonthlyFee = _view.MonthlyFee,
                Location = _view.StallLocation
            };
            try
            {
                ModelDataValidation.Validate(stall);
                _repository.InsertOrUpdate(stall, _view.StallId);
                _view.Message = _view.IsEdit ? "Stall edited successfully" : "Stall added successfully";
                
                _view.IsSuccessful = true;
                LoadAllStalls();
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
            _view.StallId = 0;
            _view.Code = "";
            _view.Status = StallStatus.AVAILABLE;
            _view.Type = string.Empty;
            _view.StallSize = 0;
            _view.MonthlyFee = 0;
            _view.StallLocation = "";
        }

        private void DeleteSelectedStall(object sender, EventArgs e)
        {
            try
            {
                var stall = (StallModel)_stallsBindingSource.Current;
                _repository.Delete(stall);
                _view.IsSuccessful = true;
                _view.Message = "Stall deleted successfully";
                LoadAllStalls();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void LoadSelectedStall()
        {
            var stall = (StallModel)_stallsBindingSource.Current;

            LoadImages(stall.StallId);

            _view.StallId = stall.StallId;
            _view.Code = stall.Code;
            _view.Status = stall.Status;
            _view.Type = stall.Type;
            _view.StallSize = stall.Size;
            _view.MonthlyFee = stall.MonthlyFee;
            _view.StallLocation = stall.Location;
        }

        private void AddNewStall(object sender, EventArgs e)
        {
            _view.IsEdit = false;
            CleanViewFields();
        }
    }
}
