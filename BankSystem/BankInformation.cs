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
    public partial class BankInformation : UserControl
    {
        public BankInformation()
        {
            InitializeComponent();
            users_count.Text = MySqlDatabase.GetCountOfUsers();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            users_count.Text = MySqlDatabase.GetCountOfUsers();
        }
    }
}
