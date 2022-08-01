using BankingProject.Helper;
using BankingProject.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankingProject
{
    public partial class Transfer : Form
    {
        private BankViewModel bankViewModel;

        public string fromIban
        {
            get
            {
                return fromIbanTextbox.Text.Trim();
            }
            set
            {
                fromIbanTextbox.Text = value;

            }
        }
        public string toIban
        {
            get
            {
                return toIbanTextbox.Text.Trim();
            }
            set
            {
                toIbanTextbox.Text = value;

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
        public Transfer(string iban)
        {
            InitializeComponent();
            InitializeViewModel();
            InitializeData(iban);
        }

        private void InitializeData(string iban) 
        {
            this.fromIban = iban;
        }
         
        private void InitializeViewModel()
        {
            bankViewModel = new BankViewModel();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateAmount() && ValidateAccount())
            {
                makeTransfer();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void makeTransfer()
        {
            var result = bankViewModel.Transfer(fromIban, toIban, amount);
            
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


        public Boolean ValidateAccount()
        {
            var isReceiverIbanNull = string.IsNullOrEmpty(toIban);
            var reg = new Regex(@"^NL[a-zA-Z0-9]{16}$");
            var regResult = reg.IsMatch(toIban);
            if (isReceiverIbanNull)
            {
                toIbanErrorProvider.SetError(amountNumeric, Constants.ibanRequired);
                return false;
            }
            else if (!regResult) 
            {
                toIbanErrorProvider.SetError(amountNumeric, Constants.ibanIncorrectFormat);
                return false;
            }
            // Check whether or not receiver account exist
            var hasAccount = bankViewModel.HasAccount(toIban);
            if (!hasAccount)
            {
                toIbanErrorProvider.SetError(amountNumeric, Constants.accNotExist);
                return false;
            }
            // Check whether or not receiver and sender are same
            var sameAccount = bankViewModel.IsSameAccount(fromIban, toIban);
            if (sameAccount)
            {
                toIbanErrorProvider.SetError(amountNumeric, Constants.sameAccount);
                return false;
            }
            // Check whether or not sender has enough value
            var isEnough = bankViewModel.HasEnoughBalance(fromIban, amount);
            if (!isEnough)
            {
                amountErrorProvider.SetError(amountNumeric, Constants.notEnoughBalance);
                return false;
            }
            toIbanErrorProvider.SetError(amountNumeric, "");
            return true;
        }

        public Boolean ValidateAmount()
        {
            if (amount <= 0)
            {
                amountErrorProvider.SetError(amountNumeric, Constants.amountLessThanZero);
                return false;
            }
            amountErrorProvider.SetError(amountNumeric, string.Empty);
            return true;
        }
        private void ShowSuccess()
        {
            MessageBox.Show(Constants.transferSuccess, Constants.transferTitle);
        }

        private void ShowError() 
        { 
            MessageBox.Show(Constants.Fail, Constants.transferTitle);
        }
    }
}
