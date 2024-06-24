using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Stall_Rental_Management_System.Views.InvoiceForm
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Print_Load(object sender, EventArgs e)
        {
            Invoice report = new Invoice();
            string connection_string = @"Data Source=34.87.58.157,1433;Initial Catalog=dbSRMS;Persist Security Info=True;User ID=sa;Password=ISADGroup3@RUPP";
            string query = @"SELECT tbInvoice.*, InvoiceID AS Expr1, FileURL AS Expr2, InvoiceNo AS Expr3, IssuedDate AS Expr4, RentFee AS Expr5, ElectricityCost AS Expr6, WaterCost AS Expr7, TotalAmount AS Expr8, Status AS Expr9, ContractID AS Expr10, StaffID AS Expr11
FROM tbInvoice";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlDataAdapter adptr = new SqlDataAdapter(query, conn);
            adptr.Fill(report, report.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("Invoice", report.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
