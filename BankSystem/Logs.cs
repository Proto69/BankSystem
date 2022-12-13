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
    public partial class Logs : UserControl
    {
        public Logs()
        {
            InitializeComponent();
            var get = BankManagment.user.DepositLogsToString();
            var give = BankManagment.user.WithdrawLogsToString();
            foreach (var item in get)
            {
                deposited.Text += item + Environment.NewLine;
            }
            foreach (var item in give)
            {
                withdrawn.Text += item + Environment.NewLine;
            }
        }
    }
}
