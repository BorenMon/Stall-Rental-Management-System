using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Repositories.Repository_Interfaces;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;

namespace Stall_Rental_Management_System.Presenters
{
    internal class ContractPresenter
    {
        // Fields
        private IContractView view;
        private IContractRepository contractRepository;
        private BindingSource contractBindingSource;
        private IEnumerable<ContractModel> contractList;

        public ContractPresenter(IContractView view, IContractRepository contractRepository)
        {
            contractBindingSource = new BindingSource();   
            this.view = view;
            this.contractRepository = contractRepository;

            //

            this.view.SearchContract += SearchContractByID;
            this.view.AddNewContract += AddNewContract;
            this.view.SaveContract += SaveContract;
            this.view.UpdateContract += UpadateContract;
            // load all contract data;
            contractBindingSource.DataSource = LoadAllContractData();
            //            //get all contracts
            this.view.SetContractBindingSource(contractBindingSource);
            // get all stall ids
            this.view.SetStallIdOnComboBox(GetAllStallIDs());
            // get all vendor ids
            this.view.SetVendorIdOnComboBox(GetAllVendorIDs());
        }
        public ContractPresenter(ContractRepository contractRepository) {
            this.contractRepository = contractRepository;
        }
        private IEnumerable<int> GetAllVendorIDs()
        {
            return contractRepository.GetAllVendorID();
        }

        private IEnumerable<int> GetAllStallIDs()
        {
            return contractRepository.GetAllStallID();

        }

        private async void SaveContract(object sender, EventArgs e)
        {
            var contract = setContractModelValue();
            if (this.view.SeletedFilePath != null)
            {
                UploadFileToMinIO(this.view.SeletedFilePath, this.view.FileName);
                contract.FileUrl = await GetGenerateURLFromMinIO(this.view.FileName);
            }
            contractRepository.Add(contract);
        }
        // methods

        public IEnumerable<ContractModel>  LoadAllContractData()
        {
            return contractRepository.GetAll();
            //contractBindingSource.DataSource = contractList;
        }

        private async void UpadateContract(object sender, EventArgs e)
        {
            var contract = setContractModelValue();

            contract.Id = int.Parse(this.view.ContractId.ToString());
            if (this.view.SeletedFilePath != null)
            {
                UploadFileToMinIO(this.view.SeletedFilePath, this.view.FileName);
                contract.FileUrl = await GetGenerateURLFromMinIO(this.view.FileName);
            }
            else
            {
                contract.FileUrl = this.view.FileUrl;
            }
            contractRepository.Update(contract);
        }

        private void AddNewContract(object sender, EventArgs e)
        {
 
        }

        private void SearchContractByID(object sender, EventArgs e)
        {

            contractList = contractRepository.GetByID(this.view.ContractId);
            this.contractBindingSource = new BindingSource();
            this.contractBindingSource.DataSource = contractList;
            this.view.SetContractBindingSource(contractBindingSource);
            //MessageBox.Show("Number of Search Found: " + contractList.Count().ToString());
        }
        // conotructor
        private ContractModel setContractModelValue()
        {
            ContractModel contract = new ContractModel();
            if (this.view.SeletedFilePath == null)
            {
                if (this.view.FileUrl == null)
                {
                    contract.FileUrl = "google.com";
                }
                else
                {
                    contract.FileUrl = this.view.FileUrl;
                }
            }
            //
            contract.Code = this.view.Code;
            contract.Status = this.view.Status;
            contract.StartDate = this.view.StartDate;
            contract.EndDate = this.view.EndDate;
            contract.VendorId = this.view.VendorId;
            contract.StallId = this.view.StallId;
            contract.StaffId = this.view.StaffId;
            return contract;
        }
        private async void UploadFileToMinIO(string selectedFilePath,string fileName)
        {

            string bucketName = "srms";
            try
            {
                await MinIOUtil
                    .GetMinioClient()
                    .PutObjectAsync(new PutObjectArgs()
                    .WithBucket(bucketName)
                    .WithObject(fileName)
                    .WithFileName(selectedFilePath));
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            };
        }
        private async Task<string> GetGenerateURLFromMinIO(string fileName)
        {

            string bucketName = "srms";
            // get Url file from minio
            // Generate the presigned URL with the maximum allowed expiration time (7 days)
            string url = await MinIOUtil.GetMinioClient()
                .PresignedGetObjectAsync(new PresignedGetObjectArgs()
                .WithBucket(bucketName)
                .WithObject(fileName)
                .WithExpiry(604800));// 7 days in seconds
            return url;
        }
    }

}
