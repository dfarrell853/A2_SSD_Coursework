
namespace SSD_A2_Coursework
{
    partial class frmAddCustomer
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
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomerRecords = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCountyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custRecordsSimpsonsDBDataSet = new SSD_A2_Coursework.CustRecordsSimpsonsDBDataSet();
            this.customerTableAdapter = new SSD_A2_Coursework.CustRecordsSimpsonsDBDataSetTableAdapters.CustomerTableAdapter();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custRecordsSimpsonsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(52, 134);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(132, 29);
            this.lblFirstname.TabIndex = 0;
            this.lblFirstname.Text = "First name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(52, 178);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(116, 29);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(52, 224);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(150, 29);
            this.lblDOB.TabIndex = 2;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(52, 272);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(179, 29);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address Line 1:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(52, 320);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(80, 29);
            this.lblTown.TabIndex = 4;
            this.lblTown.Text = "Town:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(52, 370);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(93, 29);
            this.lblCounty.TabIndex = 5;
            this.lblCounty.Text = "County:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(253, 141);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(265, 22);
            this.txtFirstname.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(253, 185);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(265, 22);
            this.txtSurname.TabIndex = 7;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(253, 231);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(265, 22);
            this.txtDOB.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(253, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(253, 327);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(265, 22);
            this.txtTown.TabIndex = 10;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(253, 377);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(265, 22);
            this.txtCounty.TabIndex = 11;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(148, 494);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(253, 75);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dgvCustomerRecords
            // 
            this.dgvCustomerRecords.AllowUserToAddRows = false;
            this.dgvCustomerRecords.AllowUserToDeleteRows = false;
            this.dgvCustomerRecords.AutoGenerateColumns = false;
            this.dgvCustomerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerFirstnameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerDOBDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn,
            this.customerTownDataGridViewTextBoxColumn,
            this.customerCountyDataGridViewTextBoxColumn});
            this.dgvCustomerRecords.DataSource = this.customerBindingSource;
            this.dgvCustomerRecords.Location = new System.Drawing.Point(579, 22);
            this.dgvCustomerRecords.Name = "dgvCustomerRecords";
            this.dgvCustomerRecords.ReadOnly = true;
            this.dgvCustomerRecords.RowHeadersWidth = 51;
            this.dgvCustomerRecords.RowTemplate.Height = 24;
            this.dgvCustomerRecords.Size = new System.Drawing.Size(488, 562);
            this.dgvCustomerRecords.TabIndex = 13;
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
            this.customerFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerFirstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDOBDataGridViewTextBoxColumn
            // 
            this.customerDOBDataGridViewTextBoxColumn.DataPropertyName = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.HeaderText = "CustomerDOB";
            this.customerDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDOBDataGridViewTextBoxColumn.Name = "customerDOBDataGridViewTextBoxColumn";
            this.customerDOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerTownDataGridViewTextBoxColumn
            // 
            this.customerTownDataGridViewTextBoxColumn.DataPropertyName = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.HeaderText = "CustomerTown";
            this.customerTownDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerTownDataGridViewTextBoxColumn.Name = "customerTownDataGridViewTextBoxColumn";
            this.customerTownDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerTownDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerCountyDataGridViewTextBoxColumn
            // 
            this.customerCountyDataGridViewTextBoxColumn.DataPropertyName = "CustomerCounty";
            this.customerCountyDataGridViewTextBoxColumn.HeaderText = "CustomerCounty";
            this.customerCountyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerCountyDataGridViewTextBoxColumn.Name = "customerCountyDataGridViewTextBoxColumn";
            this.customerCountyDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCountyDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.custRecordsSimpsonsDBDataSet;
            // 
            // custRecordsSimpsonsDBDataSet
            // 
            this.custRecordsSimpsonsDBDataSet.DataSetName = "CustRecordsSimpsonsDBDataSet";
            this.custRecordsSimpsonsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(49, 22);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(297, 51);
            this.lblAddCustomer.TabIndex = 14;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 596);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.dgvCustomerRecords);
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
            this.Name = "frmAddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custRecordsSimpsonsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerRecords;
        private CustRecordsSimpsonsDBDataSet custRecordsSimpsonsDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustRecordsSimpsonsDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTownDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCountyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAddCustomer;
    }
}

