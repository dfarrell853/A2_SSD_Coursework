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
                    insertCommand.Parameters.AddWithValue("@CustomerSurname", CustomerSurname);
                    insertCommand.Parameters.AddWithValue("@CustomerDOB", CustomerDOB);
                    insertCommand.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    insertCommand.Parameters.AddWithValue("@CustomerTown", CustomerTown);
                    insertCommand.Parameters.AddWithValue("@CustomerCounty", CustomerCounty);
                    int rows = insertCommand.ExecuteNonQuery();
                    return rows;
                }
            }                
        }
        public static int EditCustomer(int selectedCustID, string CustomerFirstname, string CustomerSurname, DateTime CustomerDOB, string CustomerAddress, string CustomerTown, string CustomerCounty)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand editCommand = new SqlCommand("UPDATE Customer SET CustomerFirstname=@CustomerFirstname, CustomerSurname=@CustomerSurname, DOB=@CustomerDOB, CustomerAddress=@CustomerAddress, CustomerTown=@CustomerTown, CustomerCounty=@CustomerCounty" + "WHERE CustomerID=@selectedCustID", connection))
                {
                    editCommand.Parameters.AddWithValue("@CustomerFirstname", CustomerFirstname);
                    editCommand.Parameters.AddWithValue("@CustomerSurname", CustomerSurname);
                    editCommand.Parameters.AddWithValue("@CustomerDOB", CustomerDOB);
                    editCommand.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
                    editCommand.Parameters.AddWithValue("@CustomerTown", CustomerTown);
                    editCommand.Parameters.AddWithValue("@CustomerCounty", CustomerCounty);
                    editCommand.Parameters.AddWithValue("@selectedCustID", selectedCustID);
                    int rows = editCommand.ExecuteNonQuery();
                    return rows;
                }
            }       
        }
        public static int DeleteCustomer(int selectedCustID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Customer " + " WHERE CustId = @selectedCustId", connection))
                {
                    deleteCommand.Parameters.AddWithValue("@selectedCustId", selectedCustID);
                    int rows = deleteCommand.ExecuteNonQuery();
                    return rows;
                }

            }
        }

        public static CustRecordsSimpsonsDBDataSet1 SelectAllCustomers()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand selectallCommand = new SqlCommand("SELECT * FROM Customer", connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectallCommand);
                        CustRecordsSimpsonsDBDataSet1 results = new CustRecordsSimpsonsDBDataSet1();
                        resultsReader.Fill(results);
                        return results;
                    }

                }
                catch  (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }

             }
        }

        public static CustRecordsSimpsonsDBDataSet1 SelectCustomersByCriteria(string searchFirstname)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string searchquery = string.Format("Select * FROM Customer WHERE CustFirstname LIKE '{0}%'", searchFirstname);
                    using (SqlCommand selectCriteriaCommand = new SqlCommand(searchquery, connection))
                    {
                        SqlDataAdapter resultsReader = new SqlDataAdapter(selectCriteriaCommand);
                        CustRecordsSimpsonsDBDataSet1 results = new CustRecordsSimpsonsDBDataSet1();
                        resultsReader.Fill(results);
                        return results;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }              
        }
    }
}
