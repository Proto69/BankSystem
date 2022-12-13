using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Deposit : UserControl
    {
        public Deposit()
        {
            InitializeComponent(); 
            string currencyOfUser = BankManagment.user.Currency;
            var user = BankManagment.user;
            if (currencyOfUser != null)
            {
                moneyShow.Text = user.Balance.ToString() + " " + currencyOfUser;
                currency.Visible = false;
            }
            else moneyShow.Text = "You have no money!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currencyOfUser = BankManagment.user.Currency;
            string currencyOfMoney = currencyOfUser;
            if (currencyOfUser == null)
            {
                currencyOfMoney = currency.Text;
            }

            var money = double.Parse(amount.Text);
            try
            {
                MySqlDatabase.DepositToBank(money, currencyOfMoney);
                moneyShow.Text = BankManagment.user.Balance.ToString() + " " + currencyOfMoney;
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
