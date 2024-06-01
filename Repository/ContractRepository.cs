using Stall_Rental_Management_System.Models;
using Stall_Rental_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Repository
{
    internal class ContractRepository : IContractRepository
    {
        private SqlConnection sqlConnection;
        //consructor
        public ContractRepository() {
            try
            {
                sqlConnection = DatabaseUtil.GetConn();
            }catch (Exception ex) { }
        }

        public void Add(ContractModel contractModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContractModel> GetAll()
        {
            var contractList = new List<ContractModel>();
            using (var sqlCommand = new SqlCommand())
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loading data...");
                }
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM tbContract";
                //
                using(var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractModel = new ContractModel();
                        contractModel.Id = (int) reader[0];
                        contractModel.FileUrl = (string)reader[1];
                        contractModel.Code = (string)reader[2];
                        contractModel.Status = (string)reader[3];
                        contractModel.StartDate = (DateTime)reader[4];
                        contractModel.EndDate = (DateTime)reader[5];
                        contractModel.StallId = (int)reader[6];
                        contractModel.VendorId = (int)reader[7];
                        contractModel.StaffId = (int)reader[8];
                        contractList.Add(contractModel);
                    }
                }
            }
            
            return contractList;
            
        }

        public IEnumerable<ContractModel> GetByID(string id)
        {
            //MessageBox.Show("Empty: " + string.IsNullOrWhiteSpace(id).ToString());
            //MessageBox.Show( "ID : " + id);
            if (string.IsNullOrWhiteSpace(id))
            {
                return GetAll();
            }
            var contractList = new List<ContractModel>();
            int contractID = int.TryParse(id, out _) ? Convert.ToInt32(id):0;
            //using (var connectionSQLSever = DatabaseUtil.GetConn())
            using (var sqlCommand = new SqlCommand())
            {
                //sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT * FROM tbContract WHERE ContractID=@id";
                //
                sqlCommand.Parameters.Add("@id",SqlDbType.Int).Value = contractID;
                //
                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var contractModel = new ContractModel();
                        contractModel.Id = (int)reader[0];
                        contractModel.FileUrl = (string)reader[1];
                        contractModel.Code = (string)reader[2];
                        contractModel.Status = (string)reader[3];
                        contractModel.StartDate = (DateTime)reader[4];
                        contractModel.EndDate = (DateTime)reader[5];
                        contractModel.StallId = (int)reader[6];
                        contractModel.VendorId = (int)reader[7];
                        contractModel.StaffId = (int)reader[8];
                        contractList.Add(contractModel);
                    }
                }
            }
            return contractList;
        }

        public void Update(ContractModel contractModel)
        {
            throw new NotImplementedException();
        }
    }
}
