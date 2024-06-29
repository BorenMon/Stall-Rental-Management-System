using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stall_Rental_Management_System.Presenters
{
    internal class VendorPresenter
    {
        private readonly IVendorView _vendorView;
        private readonly IVendorRepository _vendorRepository;

        public VendorPresenter(IVendorView vendorView, IVendorRepository vendorRepository)
        {
            var bindingSource = new BindingSource();
            _vendorView = vendorView;
            _vendorRepository = vendorRepository;
            // set Data
            bindingSource.DataSource = GetAllVendors();
            _vendorView.SetVendorBidingSource(bindingSource);
            // button action
            _vendorView.SaveVendor += SaveVendor;
            _vendorView.SearchVendor += SearchVendorById;
            _vendorView.DeleteVendor += DeleteVendorById;
            _vendorView.UpdateVendor += UpdateVendorById;

        }

        private async void UpdateVendorById(object sender, EventArgs e)
        {
            
            var model = new VendorModel
            {
                VendorID = _vendorView.VendorId
            };
            //vendorModel.VendorID = this.vendorView.VendorID;
            if (_vendorView.ProfileUrl != null)
            {
                model.ProfileUrl
                    = "vendor_profile_" + new Random().Next() + "_" + Path.GetFileName(_vendorView.ProfileUrl);
            }
            else
            {
                model.ProfileUrl = "None";
            }
            model.LastNameEN = _vendorView.LastNameEn;
            model.FirstNameEN = _vendorView.FirstNameEn;
            model.LastNameKH = _vendorView.LastNameKh;
            model.FirstNameKH = _vendorView.FirstNameKh;
            model.BirthDate = _vendorView.BirthDate;
            model.Email = _vendorView.Email;
            model.Password = _vendorView.Password;
            model.PhoneNumber = _vendorView.PhoneNumber;
            model.Address = _vendorView.Address;
            model.Gender = _vendorView.Gender;
            _vendorRepository.Update(model);
            if (_vendorView.ProfileUrl != null)
            {
                await UploadFileToMinIo(_vendorView.ProfileUrl, model.ProfileUrl);
            }
        }

        private void DeleteVendorById(object sender, EventArgs e)
        {
            _vendorRepository.Delete(_vendorView.VendorId);
            DeleteFileFromMinIo(_vendorView.ProfileUrl);
        }

        private void SearchVendorById(object sender, EventArgs e)
        {
            var vendor = _vendorRepository.GetByID(_vendorView.VendorId);
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = vendor;
            //MessageBox.Show(bindingSource.Count.ToString());
            _vendorView.SetVendorBidingSource(bindingSource);
        }

        private async void SaveVendor(object sender, EventArgs e)
        {

            VendorModel vendorModel = new VendorModel();

            //vendorModel.VendorID = this.vendorView.VendorID;
            if (_vendorView.ProfileUrl != null)
            {
                vendorModel.ProfileUrl 
                    = "vendor_profile_" + new Random().Next() + "_" + Path.GetFileName(_vendorView.ProfileUrl);
            } else{
                vendorModel.ProfileUrl = "None";
            }
            vendorModel.LastNameEN = _vendorView.LastNameEn;
            vendorModel.FirstNameEN = _vendorView.FirstNameEn;
            vendorModel.LastNameKH = _vendorView.LastNameKh;
            vendorModel.FirstNameKH = _vendorView.FirstNameKh;
            vendorModel.BirthDate = _vendorView.BirthDate;
            vendorModel.Gender = _vendorView.Gender;
            vendorModel.Email = _vendorView.Email;
            vendorModel.PhoneNumber = _vendorView.PhoneNumber;
            vendorModel.Password = _vendorView.Password;
            vendorModel.Address  = _vendorView.Address;
            _vendorRepository.Add(vendorModel);
            if(_vendorView.ProfileUrl != null)
            {
                await UploadFileToMinIo(_vendorView.ProfileUrl, vendorModel.ProfileUrl);
            }
        }

        private IEnumerable<VendorModel> GetAllVendors() {
            //MessageBox.Show((this.vendorRepository.GetAll().Count()).ToString());
            return this._vendorRepository.GetAll();
        }
        public IEnumerable<VendorModel> ReloadDatabase(IVendorRepository vendorRepository)
        {
            return vendorRepository.GetAll();
        }
        public static string GetFileNameFromMinIoUrl(string minioUrl)
        {
            try
            {
                // Parse the URL
                var uri = new Uri(minioUrl);

                // Get the path part of the URL
                var path = uri.AbsolutePath;

                // Decode the URL-encoded path
                var decodedPath = Uri.UnescapeDataString(path);

                // The object name is typically after the last '/' in the path
                var segments = decodedPath.Split('/');

                // The file name should be the last segment
                var fileName = segments[segments.Length - 1];

                // Remove any query parameters if present
                var indexOfQuestionMark = fileName.IndexOf('?');
                if (indexOfQuestionMark != -1)
                {
                    fileName = fileName.Substring(0, indexOfQuestionMark);
                }

                return fileName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Error parsing MinIO URL: {ex.Message}");
                return null;
            }
        }
        private async Task UploadFileToMinIo(string selectedFilePath, string fileName)
        {
            string bucketName = "srms";
            string folderName = "profile"; // Specify the folder name here
            string objectName = $"{folderName}/{fileName}"; // Construct the full object name including the folder

            try
            {
                await MinIoUtil
                    .GetMinioClient()
                    .PutObjectAsync(new PutObjectArgs()
                        .WithBucket(bucketName)
                        .WithObject(objectName)
                        .WithFileName(selectedFilePath));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task<string> GetPreviewPictureUrlFromMinIo(string fileName)
        {
            const string bucketName = "srms";
            const string folderName = "profile"; // Specify the folder name here
            var objectName = $"{folderName}/{fileName}"; // Construct the full object name including the folder
            try
            {
                // Generate a presigned URL for the uploaded file
                var url = await MinIoUtil.GetMinioClient()
                    .PresignedGetObjectAsync(new PresignedGetObjectArgs()
                .WithBucket(bucketName)
                        .WithObject(objectName)
                        .WithExpiry(24 * 60 * 60)); // URL valid for 24 hours
                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private static async void DeleteFileFromMinIo(string fileName)
        {
   
            const string bucketName = "srms";
            const string folderName = "profile";

            try
            {
                var objectName = $"{folderName}/{fileName}";

                // Remove the file from MinIO
                await MinIoUtil.GetMinioClient()
                    .RemoveObjectAsync(new RemoveObjectArgs()
                        .WithBucket(bucketName)
                        .WithObject(objectName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
