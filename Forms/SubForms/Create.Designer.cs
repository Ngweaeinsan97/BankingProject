namespace BankingProject
{
    partial class Create
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ibanLabel;
            System.Windows.Forms.Label nameLabel;
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ibanTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ibanErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            addressLabel = new System.Windows.Forms.Label();
            ibanLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibanErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(47, 135);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "address:";
            // 
            // ibanLabel
            // 
            ibanLabel.AutoSize = true;
            ibanLabel.Location = new System.Drawing.Point(47, 62);
            ibanLabel.Name = "ibanLabel";
            ibanLabel.Size = new System.Drawing.Size(30, 13);
            ibanLabel.TabIndex = 5;
            ibanLabel.Text = "iban:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(47, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "name:";
            // 
            // addressTextbox
            // 
            this.addressTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address", true));
            this.addressTextbox.Location = new System.Drawing.Point(145, 135);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(200, 20);
            this.addressTextbox.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BankingProject.Customer);
            // 
            // ibanTextbox
            // 
            this.ibanTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "iban", true));
            this.ibanTextbox.Location = new System.Drawing.Point(146, 62);
            this.ibanTextbox.Name = "ibanTextbox";
            this.ibanTextbox.Size = new System.Drawing.Size(200, 20);
            this.ibanTextbox.TabIndex = 6;
            // 
            // nameTextbox
            // 
            this.nameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.nameTextbox.Location = new System.Drawing.Point(145, 97);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(200, 20);
            this.nameTextbox.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(269, 173);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 28);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(182, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Create new user";
            // 
            // ibanErrorProvider
            // 
            this.ibanErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(ibanLabel);
            this.Controls.Add(this.ibanTextbox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextbox);
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibanErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox ibanTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ibanErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
    }
}