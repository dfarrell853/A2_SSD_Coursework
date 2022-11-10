using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtFirstname.Text !="")
            {
                DateTime CustomerDOB = Convert.ToDateTime(txtDOB.Text);
                CustomerDOB.ToShortDateString();
                int RowsAffected = DAL.CustomerDAL.AddNewCustomer(txtFirstname.Text, CustomerDOB);
                if (RowsAffected == 1)
                {
                    MessageBox.Show("Customer Added");
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
    }
}
