using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stall_Rental_Management_System.Views.View_Interfaces
{
    internal interface IVendorView

    {
        event EventHandler SaveVendor;
        event EventHandler SearchVendor;
        event EventHandler UpdateVendor;
        event EventHandler DeleteVendor;
        int VendorID
        {
            get;
            set;
        }
        string ProfileUrl
        {
            get;
            set;
        }
        string Address
        {
            get;
            set;
        }

        string FirstNameEN
        {
            get;
            set;
        }

        string LastNameEN
        {
            get;
            set;
        }

        string FirstNameKH
        {
            get;
            set;
        }

        string LastNameKH
        {
            get;
            set;
        }

        DateTime BirthDate
        {
            get;
            set;
        }

        string Gender
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }

        string Password
        {
            get;
            set;
        }

       string PhoneNumber
        {
            get;
            set;
        }
        void setVendorBidingSource(BindingSource bindingSource);
    }
}
