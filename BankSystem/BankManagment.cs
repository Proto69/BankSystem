namespace BankSystem
{
    public partial class BankManagment : Form
    {
        private Button lastActiveButton = new Button();
        public static PersonModel user = new PersonModel();
        public static bool islogged = false;

        public BankManagment()
        {
            InitializeComponent();
        }
        public void BankManagment_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(Button button, Control smth)
        {
            lastActiveButton.BackColor = Color.DarkSlateGray;
            button.BackColor = Color.Lavender;
            lastActiveButton = button;
            smth.Dock = DockStyle.Fill;
            showPanel.Controls.Clear();
            showPanel.Controls.Add(smth);
        }
        private bool CheckIfLogged()
        {
            if (!islogged)
            {
                MessageBox.Show("You are not logged into an account!", "No permission for this", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void bankInfo_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                BankInformation bank = new();
                ActivateButton(bankInfo, bank);
            }
        }

        private void accountInfo_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                AccountInformation acc = new();
                ActivateButton(accountInfo, acc);
            }
        }

        private void transactionLog_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                Logs log = new();
                ActivateButton(transactionLog, log);
            }
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                Deposit deposited = new(); 
                ActivateButton(deposit, deposited);
            }
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            if (CheckIfLogged())
            {
                Withdraw withdrawed = new();
                ActivateButton(withdraw, withdrawed);
            }
        }
    }
}