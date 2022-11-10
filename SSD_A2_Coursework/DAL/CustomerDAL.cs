using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SSD_A2_Coursework.DAL
{
    class CustomerDAL
    {
        private static string _connectionString =
        ConfigurationManager.ConnectionStrings["SimpsonsDBConnection"].ConnectionString;

        public static int AddNewCustomer(string CustomerFirstname, string CustomerSurname, DateTime CustomerDOB, string CustomerAddress, string CustomerTown, string CustomerCounty)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Customer VALUES(@CustomerFirstname,@CustomerSurname,@CustomerDOB,@CustomerAddress,@CustomerTown,@CustomerCounty)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@CustomerFirstname", CustomerFirstname);
                    insertCommand.Parameters.AddWithValue("@CustomerSurname", CustomerFirstname);
                    insertCommand.Parameters.AddWithValue("@CustomerDOB", CustomerFirstname);
                    insertCommand.Parameters.AddWithValue("@CustomerAddress", CustomerFirstname);
                    insertCommand.Parameters.AddWithValue("@CustomerTown", CustomerFirstname);
                    insertCommand.Parameters.AddWithValue("@CustomerCounty", CustomerFirstname);
                    int rows = insertCommand.ExecuteNonQuery();
                    return rows;
                }
            }
            

            
        }
    }
}
