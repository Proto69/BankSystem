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
            if (BankManagment.user.Balance != 0)
            {
                moneyShow.Text = user.Balance.ToString() + " " + "BGN";
            }
            else moneyShow.Text = "You have no money!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currencyOfUser = BankManagment.user.Currency;
            string currencyOfMoney = currencyOfUser;

            var money = double.Parse(amount.Text);
            try
            {
                MySqlDatabase.DepositToBank(money, currencyOfMoney);
                moneyShow.Text = BankManagment.user.Balance.ToString() + " " + "BGN";
            }
            catch (Exception ex)
            { 
                errorLabel.Text = ex.Message;
            }
        }
    }
}
