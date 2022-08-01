using BankingProject.Helper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BankingProject.ViewModels
{
    public class BankViewModel: IDisposable
    {
        public BankdbEntities db;
        
        public BankViewModel() => db = new BankdbEntities();
        public BindingSource BankBindingSource { get; set; }

        public void Load()
        {
            db.Customers.Load();
            BankBindingSource.DataSource = db.Customers.Local.ToBindingList();
        }

        public Boolean CreateUser(string iban, string name, string address)
        {
            try
            {
                Customer customer = new Customer();
                customer.iban = iban;
                customer.name = name;
                customer.address = address;
                customer.create_date = DateTime.Now;
                customer.last_updated_date = DateTime.Now;

                db.Customers.Add(customer);
                db.SaveChanges();
                               
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void refresh()
        {
            db = new BankdbEntities();
            Load();
        }

        public void Search(string keyword)
        {
            BankBindingSource.DataSource = db.Customers.Local.ToBindingList().Where(
                a => a.iban.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                a.address.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                a.name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                );

        }

        public Boolean Deposit(string iban, decimal amount)
        {
            var model = db.Customers.Where(a => a.iban == iban).SingleOrDefault();
            if(model != null)
            {
                try
                {
                    var finalAmount = amount - (amount * Constants.depositPercent);
                    model.total_amount = model.total_amount + finalAmount;
                    model.last_updated_date = DateTime.Now;

                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }

            }
            return false;
        }

        public Boolean Transfer(string from_iban, string to_iban, decimal amount)
        {
            var fromModel = db.Customers.Where(x => x.iban == from_iban).SingleOrDefault();
            var to_model = db.Customers.Where(x => x.iban == to_iban).SingleOrDefault();
            if (fromModel != null && to_model != null)
            {
                try
                {
                    fromModel.total_amount = fromModel.total_amount - amount;
                    fromModel.last_updated_date = DateTime.Now;

                    to_model.total_amount = to_model.total_amount + amount;
                    to_model.last_updated_date = DateTime.Now;

                    db.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }

            }
            return false;
        }

        public Boolean HasEnoughBalance(string iban, decimal amount)
        {
            var model = db.Customers.Where(x => x.iban == iban).SingleOrDefault();
            if(model != null)
            {
                return model.total_amount >= amount;
            }
            return false;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Boolean IsSameAccount(string fromIban, string toIban)
        {
            return fromIban == toIban;
        }

        public Boolean HasAccount(string iban)
        {
            var model = db.Customers.Where(x => x.iban == iban).SingleOrDefault();
            return model != null; 
        }

        public int totalUsers()
        {
            return db.Customers.Count();
        }

        public void DeleteAccount(string iban)
        {
            var model = db.Customers.Where(x => x.iban == iban).SingleOrDefault();
            if (model != null)
            {
                try
                {
                    db.Customers.Remove(model);
                    db.SaveChanges();
                }
                catch
                {
                    
                }
            }
        }

        public decimal GetBalance(string iban)
        {
            var model = db.Customers.Where(x => x.iban == iban).SingleOrDefault();
            if (model != null)
            {
                return model.total_amount;
            }
            return 0;
        }
    }
}
