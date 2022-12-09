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
    public partial class FrmPracticeEdit : Form
    {
        public FrmPracticeEdit()
        {
            InitializeComponent();
        }

        private void FrmPracticeEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'simpsonsDBDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.simpsonsDBDataSet1.Customer);
            RefreshDataGrid();

        }

        

        private void RefreshDataGrid()
        {
            this.customerTableAdapter2.Fill(this.simpsonsDBDataSet1.Customer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != "" | txtSurname.Text != "" | txtDOB.Text != "" | txtAddress.Text != "" | txtTown.Text != "" | txtCounty.Text != "")
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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            DateTime CustomerDOB = Convert.ToDateTime(txtDOB.Text);
        }
        int selectedCustID;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                selectedCustID = (int)row.Cells[0].Value;
                txtFirstname.Text = row.Cells[1].Value.ToString();
                txtSurname.Text = row.Cells[2].Value.ToString();
                DateTime date = (DateTime)row.Cells[3].Value;
                txtDOB.Text = date.ToShortDateString();
                txtAddress.Text = row.Cells[4].Value.ToString();
                txtTown.Text = row.Cells[5].Value.ToString();
                txtCounty.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
