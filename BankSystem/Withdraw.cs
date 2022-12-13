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
    public partial class Withdraw : UserControl
    {
        public Withdraw()
        {
            InitializeComponent();
            moneyShow.Text = BankManagment.user.Balance.ToString() + " " + BankManagment.user.Currency;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var amountOfMoney = double.Parse(amount.Text);
            try
            {
                MySqlDatabase.WithdrawFromBank(amountOfMoney);
                moneyShow.Text = BankManagment.user.Balance.ToString() + " " + BankManagment.user.Currency;
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
