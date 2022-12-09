using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace SSD_A2_Coursework
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtFirstname.Text!=""|txtSurname.Text!=""|txtDOB.Text!=""|txtAddress.Text!=""|txtTown.Text!=""|txtCounty.Text!="")
            {
                DateTime CustomerDOB = Convert.ToDateTime(txtDOB.Text);
                CustomerDOB.ToShortDateString();
                int RowsAffected = DAL.CustomerDAL.AddNewCustomer(txtFirstname.Text, txtSurname.Text, CustomerDOB, txtAddress.Text, txtTown.Text, txtCounty.Text);
                if (RowsAffected == 1)
                {
                    MessageBox.Show("Customer Added");
                    RefreshDataGrid();
                }
                else
                {
                    MessageBox.Show("Not added. Try again");
                }
            }
            else
            {
                MessageBox.Show("Enter a firstname");
               
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'custRecordsSimpsonsDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.custRecordsSimpsonsDBDataSet.Customer);
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            this.customerTableAdapter.Fill(this.custRecordsSimpsonsDBDataSet.Customer);
        }
    }
}
