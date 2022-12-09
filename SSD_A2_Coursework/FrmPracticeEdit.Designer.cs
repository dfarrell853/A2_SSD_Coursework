
namespace SSD_A2_Coursework
{
    partial class FrmPracticeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpsonsDBDataSet = new SSD_A2_Coursework.SimpsonsDBDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new SSD_A2_Coursework.SimpsonsDBDataSetTableAdapters.CustomerTableAdapter();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.custRecordsSimpsonsDBDataSet1 = new SSD_A2_Coursework.CustRecordsSimpsonsDBDataSet1();
            this.customerTableAdapter1 = new SSD_A2_Coursework.CustRecordsSimpsonsDBDataSet1TableAdapters.CustomerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpsonsDBDataSet1 = new SSD_A2_Coursework.SimpsonsDBDataSet1();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter2 = new SSD_A2_Coursework.SimpsonsDBDataSet1TableAdapters.CustomerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custRecordsSimpsonsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // simpsonsDBDataSet
            // 
            this.simpsonsDBDataSet.DataSetName = "SimpsonsDBDataSet";
            this.simpsonsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.simpsonsDBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 470);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(284, 93);
            this.btnAddCustomer.TabIndex = 25;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCounty
            // 
            this.txtCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounty.Location = new System.Drawing.Point(276, 307);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(257, 27);
            this.txtCounty.TabIndex = 24;
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTown.Location = new System.Drawing.Point(276, 257);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(257, 27);
            this.txtTown.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(276, 209);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 27);
            this.txtAddress.TabIndex = 22;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(276, 161);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(257, 27);
            this.txtDOB.TabIndex = 21;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(276, 115);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(257, 22);
            this.txtSurname.TabIndex = 20;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(276, 71);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(257, 22);
            this.txtFirstname.TabIndex = 19;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(75, 300);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(93, 29);
            this.lblCounty.TabIndex = 18;
            this.lblCounty.Text = "County:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(75, 250);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(80, 29);
            this.lblTown.TabIndex = 17;
            this.lblTown.Text = "Town:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(75, 202);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(179, 29);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address Line 1:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(75, 154);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(150, 29);
            this.lblDOB.TabIndex = 15;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(75, 108);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(116, 29);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(75, 64);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(132, 29);
            this.lblFirstname.TabIndex = 13;
            this.lblFirstname.Text = "First name:";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(349, 469);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(279, 94);
            this.btnEditCustomer.TabIndex = 26;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.custRecordsSimpsonsDBDataSet1;
            // 
            // custRecordsSimpsonsDBDataSet1
            // 
            this.custRecordsSimpsonsDBDataSet1.DataSetName = "CustRecordsSimpsonsDBDataSet1";
            this.custRecordsSimpsonsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFirstnameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTownDataGridViewTextBoxColumn,
            this.customerCountyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(656, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(441, 560);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // simpsonsDBDataSet1
            // 
            this.simpsonsDBDataSet1.DataSetName = "SimpsonsDBDataSet1";
            this.simpsonsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.simpsonsDBDataSet1;
            // 
            // customerTableAdapter2
            // 
            this.customerTableAdapter2.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerFirstnameDataGridViewTextBoxColumn
            // 
            this.customerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstname";
            this.customerFirstnameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstname";
            this.customerFirstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerFirstnameDataGridViewTextBoxColumn.Name = "customerFirstnameDataGridViewTextBoxColumn";
            this.customerFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDOBDataGridViewTextBoxColumn
            // 
            this.customerDOBDataGridViewTextBoxColumn.DataPropertyName = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.HeaderText = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDOBDataGridViewTextBoxColumn.Name = "customerDOBDataGridViewTextBoxColumn";
            this.customerDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTownDataGridViewTextBoxColumn
            // 
            this.customerTownDataGridViewTextBoxColumn.DataPropertyName = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.HeaderText = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerTownDataGridViewTextBoxColumn.Name = "customerTownDataGridViewTextBoxColumn";
            this.customerTownDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerCountyDataGridViewTextBoxColumn
            // 
            this.customerCountyDataGridViewTextBoxColumn.DataPropertyName = "CustomerCounty";
            this.customerCountyDataGridViewTextBoxColumn.HeaderText = "CustomerCounty";
            this.customerCountyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerCountyDataGridViewTextBoxColumn.Name = "customerCountyDataGridViewTextBoxColumn";
            this.customerCountyDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmPracticeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCounty);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstname);
            this.Name = "FrmPracticeEdit";
            this.Text = "FrmPracticeEdit";
            this.Load += new System.EventHandler(this.FrmPracticeEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custRecordsSimpsonsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SimpsonsDBDataSet simpsonsDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private SimpsonsDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnEditCustomer;
        private CustRecordsSimpsonsDBDataSet1 custRecordsSimpsonsDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CustRecordsSimpsonsDBDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SimpsonsDBDataSet1 simpsonsDBDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private SimpsonsDBDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountyDataGridViewTextBoxColumn;
    }
}