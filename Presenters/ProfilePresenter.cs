
using System;
using System.Data.SqlClient;
using Stall_Rental_Management_System.Enums;
using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Presenters.Common;
using Stall_Rental_Management_System.Utils;
using Stall_Rental_Management_System.Views;


namespace Stall_Rental_Management_System.Presenters
{
    public class ProfilePresenter
    {
        private readonly FrmProfile _view;

        public ProfilePresenter(FrmProfile view)
        {
            _view = view;
        }

        public void Update()
        {
            var user = new User
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
                Address = _view.Address
            };
            
            var currentUser = CurrentUserUtil.User;
            
            try
            {
                ModelDataValidation.Validate(user);
                
                // Update Query
                var tableName = currentUser.UserType == UserType.VENDOR ? "tbVendor" : "tbStaff";
                using (var connection = new SqlConnection(DatabaseUtil.GetConnectionString()))
                using (var command = new SqlCommand($"UPDATE {tableName} SET ProfileImageURL = @ProfileImageUrl, LastNameEN = @LastNameEn, FirstNameEN = @FirstNameEn, LastNameKH = @LastNameKh, FirstNameKH = @FirstNameKh, BirthDate = @BirthDate, Gender = @Gender, Email = @Email, Address = @Address, PhoneNumber = @PhoneNumber WHERE {(currentUser.UserType == UserType.VENDOR ? "VendorID" : "StaffID")} = @UserId", connection))
                {
                    command.Parameters.AddWithValue("@UserId", currentUser.UserId);
                    command.Parameters.AddWithValue("@ProfileImageUrl", user.ProfileImageUrl);
                    command.Parameters.AddWithValue("@LastNameEn", user.LastNameEn);
                    command.Parameters.AddWithValue("@FirstNameEn", user.FirstNameEn);
                    command.Parameters.AddWithValue("@LastNameKh", user.LastNameKh);
                    command.Parameters.AddWithValue("@FirstNameKh", user.FirstNameKh);
                    command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                    command.Parameters.AddWithValue("@Gender", user.Gender.ToString());
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Address", user.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);

                    connection.Open();
                    command.ExecuteNonQuery();

                    // Update current user
                    currentUser.ProfileImageUrl = user.ProfileImageUrl;
                    currentUser.LastNameEn = user.LastNameEn;
                    currentUser.FirstNameEn = user.FirstNameEn;
                    currentUser.LastNameKh = user.LastNameKh;
                    currentUser.FirstNameKh = user.FirstNameKh;
                    currentUser.BirthDate = user.BirthDate;
                    currentUser.Gender = user.Gender;
                    currentUser.Email = user.Email;
                    currentUser.Address = user.Address;
                    currentUser.PhoneNumber = user.PhoneNumber;
                    CurrentUserUtil.User = currentUser;
                }
                
                _view.Message = "Profile updated successfully";
            }
            catch (Exception ex)
            {
                _view.Message = ex.Message;
            }
        }
    }
}