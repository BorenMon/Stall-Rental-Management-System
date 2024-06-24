using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stall_Rental_Management_System.Models
{
    internal class VendorModel
    {
        // fields
        private int vendorID;
        private string profileUrl;
        private string firstNameEN;
        private string lastNameEN;
        private string firstNameKH;
        private string lastNameKH;
        private DateTime birthDate;
        private string gender;
        private string email;
        private string password;
        private string phoneNumber;
        private string address;
        //
        // properties
        public int VendorID
        {
            get { return vendorID; }
            set { vendorID = value; }
        }
        [StringLength(555)]

        public string ProfileUrl
        {
            get { return profileUrl; }
            set { this.profileUrl = value; }
        }

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        [StringLength(100)]

        public string FirstNameEN
        {
            get { return firstNameEN; }
            set { firstNameEN = value; }
        }
        [StringLength(100)]
        public string LastNameEN
        {
            get { return lastNameEN; }
            set { lastNameEN = value; }
        }

        public string FirstNameKH
        {
            get { return firstNameKH; }
            set { firstNameKH = value; }
        }

        public string LastNameKH
        {
            get { return lastNameKH; }
            set { lastNameKH = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [StringLength(255)]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public VendorModel() { }

        public VendorModel(int vendorID, string profileUrl ,string firstNameEN, string lastNameEN, string firstNameKH, string lastNameKH, DateTime birthDate, string gender, string email, string password, string phoneNumber)
        {
            this.vendorID = vendorID;
            this.profileUrl = profileUrl;
            this.firstNameEN = firstNameEN;
            this.lastNameEN = lastNameEN;
            this.firstNameKH = firstNameKH;
            this.lastNameKH = lastNameKH;
            this.birthDate = birthDate;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
    }
}
