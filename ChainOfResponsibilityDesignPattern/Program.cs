using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyWithdraw = new MoneyWithdraw("customerId", 10000, "1111");

            Employee cashier = new Cashier();
            Employee executive = new Executive();
            Employee manager = new Manager();
            Employee regionManager = new RegionManager();

            cashier.SetNextApprover(executive);
            executive.SetNextApprover(manager);
            manager.SetNextApprover(regionManager);

            cashier.ProcessRequest(moneyWithdraw);

        }
    }
}
