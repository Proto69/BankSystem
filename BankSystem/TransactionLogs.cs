using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace BankSystem
{
    public class TransactionLogs
    {
        public int Id = 0;
        public string Date { get; set; }
        public string? TypeOfAction { get; set; }
        public double AmountOfMoney { get; set; }

        public TransactionLogs(int id, string date, string? typeOfAction, double amountOfMoney)
        {
            Id = id;
            Date = date;
            TypeOfAction = typeOfAction;
            AmountOfMoney = amountOfMoney;
        }

        public override string ToString()
        {
            return $"<{Id}> {Date}  {AmountOfMoney}  {BankManagment.user.Currency}";
        }
    }
}