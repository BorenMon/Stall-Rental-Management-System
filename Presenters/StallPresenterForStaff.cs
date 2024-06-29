using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Views;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;


namespace Stall_Rental_Management_System.Presenters
{
    public class StallPresenterForStaff
    {
        // Fields
        private readonly FrmStallForStaff _view;
        private readonly StallRepository _repository;
        private readonly BindingSource _stallsBindingSource;
        private IEnumerable<StallModel> _stallList;

        // Constructor
        public StallPresenterForStaff(FrmStallForStaff view, StallRepository repository)
        {
            _stallsBindingSource = new BindingSource();
            _view = view;
            _repository = repository;

            // Subscribe event handler methods to view events
            _view.SearchEvent += SearchStall;
            _view.ViewEvent += ViewStall;
            _view.ImageListBox.SelectedIndexChanged += OnImageSelected;

            // Set staffs binding source
            _view.SetStallListBindingSource(_stallsBindingSource);

            // Load staff list view
            LoadAllStalls();
        }

        private void LoadImages(int stallId)
        {
            var images = _repository.GetImagesByStallId(stallId);
            _view.ImageListBox.DataSource = images;
            _view.ImageListBox.DisplayMember = "FileName";
            if (images != null) { _view.ImagePictureBox.ImageLocation = null; } 
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
    }
}
