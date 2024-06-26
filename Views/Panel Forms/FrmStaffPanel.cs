using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stall_Rental_Management_System.Services;

namespace Stall_Rental_Management_System.Views.Panel_Forms
{
    public partial class FrmStaffPanel : Form
    {
        private readonly AuthenticationService _authService;
        public FrmStaffPanel(AuthenticationService authService)
        {
            InitializeComponent();
            
            _authService = authService;
        }
    }
}
