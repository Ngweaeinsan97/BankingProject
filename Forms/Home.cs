using BankingProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingProject
{
    public partial class Home : Form
    {
        private BankViewModel bankViewModel;
        public Home()
        {
            InitializeComponent();
            InitializeViewModel();
            InitializeData();
        }
        private void InitializeViewModel()
        {
            bankViewModel = new BankViewModel();
            bankViewModel.BankBindingSource = customerBindingSource;
            this.Load += delegate { bankViewModel.Load(); };           
        }

        private void InitializeData()
        {
            dataGridView.DataSource = customerBindingSource;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.FormClosed += new FormClosedEventHandler(Dialog_FormClosed);
            create.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Deposit")
            {
                var model = dataGridView.Rows[e.RowIndex].DataBoundItem as Customer;
                Deposit deposit = new Deposit(model.iban);
                deposit.FormClosed += new FormClosedEventHandler(Dialog_FormClosed);
                deposit.Show();
               
            }
            else if (dataGridView.Columns[e.ColumnIndex].Name == "Transfer")
            {
                var model = dataGridView.Rows[e.RowIndex].DataBoundItem as Customer;
                Transfer transfer = new Transfer(model.iban);
                transfer.FormClosed += new FormClosedEventHandler(Dialog_FormClosed);
                transfer.Show();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var keyword = searchTextBox.Text.Trim();
            bankViewModel.Search(keyword);
        }

        private void Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            bankViewModel.refresh();
            dataGridView.Refresh();
        }
    }
}
