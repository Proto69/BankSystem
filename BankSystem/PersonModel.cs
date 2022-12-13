using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class PersonModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance = 0;
        public string Currency { get; set; }
        public List<TransactionLogs> Logs = new();

        public List<string> WithdrawLogsToString()
        {
            List<string> a = new();
            foreach (var item in Logs)
            {
                if (item.TypeOfAction == "withdrawn")
                {
                    a.Add($"{item}");
                }
            }
            return a;
        }
        public List<string> DepositLogsToString()
        {
            List<string> a = new();
            foreach (var item in Logs)
            {
                if (item.TypeOfAction == "deposited")
                {
                    a.Add($"{item}");
                }
            }
            return a;
        }
    }
}
