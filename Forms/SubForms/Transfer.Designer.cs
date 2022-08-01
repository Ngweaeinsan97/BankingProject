namespace BankingProject
{
    partial class Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fromIbanTextbox = new System.Windows.Forms.TextBox();
            this.toIbanTextbox = new System.Windows.Forms.TextBox();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fromIbanErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toIbanErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.amountErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIbanErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIbanErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From IBAN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "To IBAN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // fromIbanTextbox
            // 
            this.fromIbanTextbox.Enabled = false;
            this.fromIbanTextbox.Location = new System.Drawing.Point(140, 69);
            this.fromIbanTextbox.Name = "fromIbanTextbox";
            this.fromIbanTextbox.Size = new System.Drawing.Size(221, 20);
            this.fromIbanTextbox.TabIndex = 4;
            // 
            // toIbanTextbox
            // 
            this.toIbanTextbox.Location = new System.Drawing.Point(140, 107);
            this.toIbanTextbox.Name = "toIbanTextbox";
            this.toIbanTextbox.Size = new System.Drawing.Size(221, 20);
            this.toIbanTextbox.TabIndex = 5;
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(140, 146);
            this.amountNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(221, 20);
            this.amountNumeric.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(286, 190);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fromIbanErrorProvider
            // 
            this.fromIbanErrorProvider.ContainerControl = this;
            // 
            // toIbanErrorProvider
            // 
            this.toIbanErrorProvider.ContainerControl = this;
            // 
            // amountErrorProvider
            // 
            this.amountErrorProvider.ContainerControl = this;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.amountNumeric);
            this.Controls.Add(this.toIbanTextbox);
            this.Controls.Add(this.fromIbanTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Transfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromIbanErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toIbanErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fromIbanTextbox;
        private System.Windows.Forms.TextBox toIbanTextbox;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider fromIbanErrorProvider;
        private System.Windows.Forms.ErrorProvider toIbanErrorProvider;
        private System.Windows.Forms.ErrorProvider amountErrorProvider;
    }
}