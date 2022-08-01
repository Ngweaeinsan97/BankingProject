using BankingProject.Helper;
using BankingProject.ViewModels;
using System;
using System.Windows.Forms;

namespace BankingProject
{
    public partial class Deposit : Form
    {
        private BankViewModel bankViewModel;

        //need to update
        public string iban
        {
            get
            {
                return ibanTextbox.Text.Trim();
            }
            set
            {
                ibanTextbox.Text = value;

            }
        }
        public decimal amount
        {
            get
            {
                return amountNumeric.Value;
            }
            set
            {
                amountNumeric.Value = value;

            }
        }

        public Deposit(string iban)
        {
            InitializeComponent();
            InitializeViewModel();
            InitializeData(iban);
        }
        private void InitializeViewModel()
        {
            bankViewModel = new BankViewModel();
        }
        private void InitializeData(string iban)
        {
            this.iban = iban;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateAmount())
            {
               makeDeposit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeDeposit()
        {
            var result = bankViewModel.Deposit(iban, amount);
            if (result)
            {
                ShowSuccess();
                this.Close();
            }
            else
            {
                ShowError();
            }
        }


        public Boolean ValidateAmount()
        {
            if (amount <= 0 )
            {
                amountErrorProvider.SetError(amountNumeric, Constants.amountLessThanZero);
                return false;
            }
            amountErrorProvider.SetError(amountNumeric, string.Empty);
            return true;
        }
        private void ShowSuccess()
        {
            MessageBox.Show(Constants.depositSuccess, Constants.depositTitle);
        }

        private void ShowError()
        {
            MessageBox.Show(Constants.Fail, Constants.depositTitle);
        }
     
    }
}
