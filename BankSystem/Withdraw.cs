using Microsoft.VisualBasic.ApplicationServices;
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
            if (BankManagment.user.Balance != 0)
            {
                moneyShow.Text = BankManagment.user.Balance.ToString() + " " + "BGN";
            }
            else moneyShow.Text = "You have no money!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var amountOfMoney = double.Parse(amount.Text);
            try
            {
                MySqlDatabase.WithdrawFromBank(amountOfMoney);
                moneyShow.Text = BankManagment.user.Balance.ToString() + " BGN";
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }
    }
}
