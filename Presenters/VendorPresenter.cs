using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Presenters

{
    
    internal class VendorPresenter
    {
        private IVendorView vendorView;
        private IVendorRepository vendorRepository;
        private BindingSource bindingSource;
        private IEnumerable<VendorModel> modelList;
        public VendorPresenter() { }
        public VendorPresenter(IVendorView vendorView, IVendorRepository vendorRepository)
        {
            this.bindingSource = new BindingSource();
            this.vendorView = vendorView;
            this.vendorRepository = vendorRepository;
            // set Data
            this.bindingSource.DataSource = GetAllVendors();
            this.vendorView.setVendorBidingSource(bindingSource);
            // button action
            this.vendorView.SaveVendor += SaveVendor;
            this.vendorView.SearchVendor += SearchVendorByID;
            this.vendorView.DeleteVendor += DeleteVendorByID;
            this.vendorView.UpdateVendor += UpdateVendorrById;

        }

        private async void UpdateVendorrById(object sender, EventArgs e)
        {
            
            VendorModel model = new VendorModel ();
            model.VendorID = vendorView.VendorID;
            //vendorModel.VendorID = this.vendorView.VendorID;
            if (vendorView.ProfileUrl != null)
            {
                model.ProfileUrl
                    = "vendor_profile_" + new Random().Next() + "_" + Path.GetFileName(vendorView.ProfileUrl);
            }
            else
            {
                model.ProfileUrl = "None";
            }
            model.LastNameEN = vendorView.LastNameEN;
            model.FirstNameEN = vendorView.FirstNameEN;
            model.Email = vendorView.Email;
            model.Password = vendorView.Password;
            model.PhoneNumber = vendorView.PhoneNumber;
            model.Address = vendorView.Address;
            model.Gender = vendorView.Gender;
            vendorRepository.Update(model);
            if (vendorView.ProfileUrl != null)
            {
                await UploadFileToMinIO(vendorView.ProfileUrl, model.ProfileUrl);
            }
        }

        private async void DeleteVendorByID(object sender, EventArgs e)
        {
            vendorRepository.Delete(vendorView.VendorID);
            bool isDeleted = await DeleteFileFromMinIO(vendorView.ProfileUrl);
        }

        private void SearchVendorByID(object sender, EventArgs e)
        {
            var vendor = vendorRepository.GetByID(vendorView.VendorID);
            
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = vendor;
            //MessageBox.Show(bindingSource.Count.ToString());
            vendorView.setVendorBidingSource(bindingSource);
        }

        private async void SaveVendor(object sender, EventArgs e)
        {

            VendorModel vendorModel = new VendorModel();

            //vendorModel.VendorID = this.vendorView.VendorID;
            if (vendorView.ProfileUrl != null)
            {
                vendorModel.ProfileUrl 
                    = "vendor_profile_" + new Random().Next() + "_" + Path.GetFileName(vendorView.ProfileUrl);
            } else{
                vendorModel.ProfileUrl = "None";
            }
            vendorModel.LastNameEN = vendorView.LastNameEN;
            vendorModel.FirstNameEN = vendorView.FirstNameEN;
            vendorModel.Gender = vendorView.Gender;
            vendorModel.Email = vendorView.Email;
            vendorModel.PhoneNumber = vendorView.PhoneNumber;
            vendorModel.Password = vendorView.Password;
            vendorModel.Address  = vendorView.Address;
            vendorRepository.Add(vendorModel);
            if(vendorView.ProfileUrl != null)
            {
                await UploadFileToMinIO(vendorView.ProfileUrl, vendorModel.ProfileUrl);
            }
        }

        public IEnumerable<VendorModel> GetAllVendors() {
            //MessageBox.Show((this.vendorRepository.GetAll().Count()).ToString());
            return this.vendorRepository.GetAll();
        }
        public IEnumerable<VendorModel> ReloadDatabase(IVendorRepository vendorRepository)
        {
            return vendorRepository.GetAll();
        }
        public static string GetFileNameFromMinIOUrl(string minioUrl)
        {
            try
            {
                // Parse the URL
                Uri uri = new Uri(minioUrl);

                // Get the path part of the URL
                string path = uri.AbsolutePath;

                // Decode the URL-encoded path
                string decodedPath = Uri.UnescapeDataString(path);

                // The object name is typically after the last '/' in the path
                string[] segments = decodedPath.Split('/');

                // The file name should be the last segment
                string fileName = segments[segments.Length - 1];

                // Remove any query parameters if present
                int indexOfQuestionMark = fileName.IndexOf('?');
                if (indexOfQuestionMark != -1)
                {
                    fileName = fileName.Substring(0, indexOfQuestionMark);
                }

                return fileName;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing MinIO URL: {ex.Message}");
                return null;
            }
        }
        private async Task UploadFileToMinIO(string selectedFilePath, string fileName)
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task<string> GetPreviewPictureUrlFromMinIO(string fileName)
        {
            string bucketName = "srms";
            string folderName = "profile"; // Specify the folder name here
            string objectName = $"{folderName}/{fileName}"; // Construct the full object name including the folder
            try
            {
                // Generate a presigned URL for the uploaded file
                string url = await MinIoUtil.GetMinioClient()
                    .PresignedGetObjectAsync(new PresignedGetObjectArgs()
                .WithBucket(bucketName)
                        .WithObject(objectName)
                        .WithExpiry(24 * 60 * 60)); // URL valid for 24 hours
                return url;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static async Task<bool> DeleteFileFromMinIO(string fileName)
        {
   
            string bucketName = "srms";
            string folderName = "profile";

            try
            {
                string objectName = $"{folderName}/{fileName}";

                // Remove the file from MinIO
                await MinIoUtil.GetMinioClient()
                    .RemoveObjectAsync(new RemoveObjectArgs()
                        .WithBucket(bucketName)
                        .WithObject(objectName));

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
