namespace BankingProject
{
    partial class Home
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            this.ibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastupdateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deposit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Transfer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(906, 48);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 33);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(25, 101);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(991, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ibanDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.lastupdateddateDataGridViewTextBoxColumn,
            this.Deposit,
            this.Transfer});
            dataGridView.DataSource = this.customerBindingSource1;
            dataGridView.Location = new System.Drawing.Point(25, 146);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new System.Drawing.Size(991, 533);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ibanDataGridViewTextBoxColumn
            // 
            this.ibanDataGridViewTextBoxColumn.DataPropertyName = "iban";
            this.ibanDataGridViewTextBoxColumn.HeaderText = "iban";
            this.ibanDataGridViewTextBoxColumn.Name = "ibanDataGridViewTextBoxColumn";
            this.ibanDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.Width = 120;
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "create_date";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastupdateddateDataGridViewTextBoxColumn
            // 
            this.lastupdateddateDataGridViewTextBoxColumn.DataPropertyName = "last_updated_date";
            this.lastupdateddateDataGridViewTextBoxColumn.HeaderText = "last_updated_date";
            this.lastupdateddateDataGridViewTextBoxColumn.Name = "lastupdateddateDataGridViewTextBoxColumn";
            this.lastupdateddateDataGridViewTextBoxColumn.Width = 120;
            // 
            // Deposit
            // 
            this.Deposit.HeaderText = "Deposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.Text = "Deposit";
            this.Deposit.UseColumnTextForButtonValue = true;
            // 
            // Transfer
            // 
            this.Transfer.HeaderText = "Transfer";
            this.Transfer.Name = "Transfer";
            this.Transfer.Text = "Transfer";
            this.Transfer.UseColumnTextForButtonValue = true;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(BankingProject.Customer);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BankingProject.Customer);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 701);
            this.Controls.Add(dataGridView);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.btnCreate);
            this.Name = "Home";
            this.Text = "Banking System";
            ((System.ComponentModel.ISupportInitialize)(dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        public static System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Deposit;
        private System.Windows.Forms.DataGridViewButtonColumn Transfer;
        private System.Windows.Forms.BindingSource customerBindingSource1;
    }
}

