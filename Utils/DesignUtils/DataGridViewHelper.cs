using System.Collections.Generic;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Utils.DesignUtils
{
    public static class DataGridViewHelper
    {
        public static void SetDataGridViewColumns(
            DataGridView dataGridView, 
            BindingSource bindingSource, 
            List<(string DataPropertyName, string HeaderText, string Name)> columns)
        {
            // Set the data source
            dataGridView.DataSource = bindingSource;

            // Prevent automatic column generation
            dataGridView.AutoGenerateColumns = false;

            // Clear existing columns
            dataGridView.Columns.Clear();

            // Add the columns you want to display
            foreach (var column in columns)
            {
                dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = column.DataPropertyName, 
                    HeaderText = column.HeaderText, 
                    Name = column.Name
                });
            }

            // Set the AutoSizeColumnsMode
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}