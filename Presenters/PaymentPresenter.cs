using Minio.DataModel.Args;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Repositories;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views.View_Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Presenters
{
    internal class PaymentPresenter
    {
        private PaymentRepository repository;
        private IPaymentView paymentView;
        private BindingSource bindingSource;


        public PaymentPresenter(IPaymentView view, PaymentRepository paymentRepository, Object ob)
        {
            this.bindingSource = new BindingSource();
            this.bindingSource.DataSource = paymentRepository.GetAll();
            this.paymentView = view;
            this.paymentView.setPaymentBinding(this.bindingSource);
            BindingSource binding = new BindingSource();
            binding.DataSource = paymentRepository.GetAllPaymentReferencces();
            this.paymentView.setPaymentReferenceBinding(binding);
        }
        public PaymentPresenter(IPaymentView paymentViewm, PaymentRepository paymentRepository
            ) {
            this.paymentView = paymentViewm;
            this.repository = paymentRepository;
            this.bindingSource = new BindingSource();
            bindingSource.DataSource = GetPaymentModels();
            this.paymentView.setPaymentBinding(this.bindingSource);
            BindingSource reference = new BindingSource();
            reference.DataSource = repository.GetAllPaymentReferencces();
            this.paymentView
                .setPaymentReferenceBinding(reference);
            this.paymentView.setInvoiceID(repository.getAllInvoiceIDs());
            paymentView.SavePayment += SaveNewPayment;
            paymentView.SearchPayment += SearchPayment;
            paymentView.DeletePayment += DeletePayment;
            paymentView.UpdatePayment += UpdatePyment;
        }

        private void UpdatePyment(object sender, EventArgs e)
        {
            PaymentModel payment = new PaymentModel();
            payment.PaymentID = paymentView.PaymentID;
            payment.PaymentMethod = paymentView.PaymentMethod;
            payment.PaymentDate = paymentView.PaymentDate;
            payment.Status = paymentView.Status;
            payment.Currency = paymentView.Currency;
            payment.Amount = paymentView.Amount;
            payment.InvoiceID = paymentView.InvoiceID;
            repository.updatePayment(payment);
        }

        private void DeletePayment(object sender, EventArgs e)
        {
            repository.DeletePaymentByID(this.paymentView.PaymentID);
        }

        private void SearchPayment(object sender, EventArgs e)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = repository.getPaymentBYID(this.paymentView.PaymentID);
            this.paymentView.setPaymentBinding(binding);
        }
        
        private async void SaveNewPayment(object sender, EventArgs e)
        {
            var payment = new PaymentModel();
            payment.PaymentMethod = this.paymentView.PaymentMethod;
            payment.PaymentDate = this.paymentView.PaymentDate;
            payment.Status = this.paymentView.Status;
            payment.Currency = this.paymentView.Currency;
            payment.Amount = this.paymentView.Amount;
            payment.InvoiceID = this.paymentView.InvoiceID;
            if (this.paymentView.ReferenceImgeUrl != null && paymentView.ReferenceFileName!=null)
            {
               string img  = "payment_reference_image_" + new Random().Next()  + "_"+ Path.GetFileName(this.paymentView.ReferenceImgeUrl);
               string file = "payment_reference_image_" + new Random().Next() + "_" + Path.GetFileName(this.paymentView.ReferenceFileName);
               var reference = new PaymentReferenceModel();
                reference.PaymentID = payment.PaymentID;
                reference.ImageURL = img;
                reference.FileName = file;
                repository.Add(payment,reference);
               await UploadFileToMinIO(paymentView.ReferenceImgeUrl,img);
               await UploadFileToMinIO(paymentView.ReferenceFileName, file);
            }
        }

        private IEnumerable<PaymentModel> GetPaymentModels()
        {
            return repository.GetAll();
        }
        //
        private async Task UploadFileToMinIO(string selectedFilePath, string fileName)
        {
            string bucketName = "srms";
            string folderName = "payment"; // Specify the folder name here
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
    }
}
