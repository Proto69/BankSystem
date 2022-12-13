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
    public partial class AccountInformation : UserControl
    {
        public AccountInformation()
        {
            InitializeComponent();
            username.Text = $"Your username is: {BankManagment.user.Username}";
            money.Text = BankManagment.user.Balance.ToString();
            var currency1 = BankManagment.user.Currency;
            if (currency1 != null) currency.Text = currency1;
            else currency.Text = "No chosen currency!";
        }
    }
}
