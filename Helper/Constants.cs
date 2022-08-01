using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Helper
{
    public class Constants
    {
        //constant for validation error message
        public const string ibanRequired = "IBAN is required!";
        public const string ibanIncorrectFormat = "IBAN is not in correct format!";
        public const string ibanHasAccount = "This user already exists!";
        public const string nameRequired = "Name is required!";
        public const string addressRequired = "Address is required!";
        public const string amountLessThanZero = "Amount must be greater than zero!";
        public const string accNotExist = "Receiver Account doesn't exist!";
        public const string sameAccount = "IBAN is not in correct format!";
        public const string notEnoughBalance = "Sender doesn't have enough balance to transfer!";


        // constant for alert message
        public const string createSuccess = "Created successfully!";
        public const string depositSuccess = "Deposit successfully!";
        public const string transferSuccess = "Transferred successfully!";
        public const string Fail = "Something went wrong!";

        //Constant for alert message title
        public const string createTitle = "Create User";
        public const string depositTitle = "Deposit Cash";
        public const string transferTitle = "Transfer Cash";


        // constant for deposit percent 
        public const decimal depositPercent = 0.01m;

    }
}
