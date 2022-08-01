using BankingProject.Helper;
using BankingProject.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankingProject
{
    public partial class Create : Form
    {
        private BankViewModel bankViewModel;
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
        public string name
        {
            get
            {
                return nameTextbox.Text.Trim();
            }
            set
            {
                nameTextbox.Text = value;

            }
        }
        public string address
        {
            get
            {
                return addressTextbox.Text.Trim();
            }
            set
            {
                addressTextbox.Text = value;

            }
        }

        public Create()
        {
            InitializeComponent();
            InitializeViewModel();
        }
        private void InitializeViewModel()
        {
            bankViewModel = new BankViewModel();
        }      
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var validateResult = ValidateTextBox();
            if (validateResult)
            {
            var result = bankViewModel.CreateUser(iban, name, address);
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
        }
  
        public Boolean ValidateTextBox() 
        {
            var reg = new Regex(@"^NL[a-zA-Z0-9]{16}$");
            var regResult = reg.IsMatch(iban);
            var isIbanNull = string.IsNullOrEmpty(ibanTextbox.Text);
            var isNameNull = string.IsNullOrEmpty(name);
            var isAddressNull = string.IsNullOrEmpty(address);
            var hasAccount = bankViewModel.HasAccount(iban);
            if (isIbanNull)
            {
                ibanErrorProvider.SetError(ibanTextbox, Constants.ibanRequired);
            }
            else if (!regResult)
            {
                ibanErrorProvider.SetError(ibanTextbox, Constants.ibanIncorrectFormat);
            } 
            else if (hasAccount)
            {
                ibanErrorProvider.SetError(ibanTextbox, Constants.ibanHasAccount);
            }
            else
            {
                ibanErrorProvider.SetError(ibanTextbox, "");
            }
            
            if (isNameNull)
            {
                nameErrorProvider.SetError(nameTextbox, Constants.nameRequired);
            }
            else
            {
                nameErrorProvider.SetError(nameTextbox, "");
            }

            if (isAddressNull)
            {
                addressErrorProvider.SetError(addressTextbox, Constants.addressRequired);
            }
            else
            {
                addressErrorProvider.SetError(addressTextbox, "");
            }

            return regResult && !isNameNull && !isAddressNull && !hasAccount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowSuccess()
        {
            MessageBox.Show(Constants.createSuccess, Constants.createTitle);
        }

        private void ShowError()
        {
            MessageBox.Show(Constants.Fail, Constants.createTitle);
        }
    }
}
