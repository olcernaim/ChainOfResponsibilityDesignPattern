using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class MoneyWithdraw
    {
        public string CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string AccountId { get; set; }

        public MoneyWithdraw(string customerId, decimal amount, string accountId)
        {
            CustomerId = customerId;
            Amount = amount;
            AccountId = accountId;
        }
    }
}
