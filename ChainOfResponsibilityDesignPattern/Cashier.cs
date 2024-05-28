using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public class Cashier : Employee
    {
        public override void ProcessRequest(MoneyWithdraw req)
        {
            if (req.Amount <= 20000)
            {
                Console.WriteLine("{0} withdrawal confirmed by #{1} $", this.GetType().Name, req.Amount);
            }
            else if (NextApprover != null)
            {
                Console.WriteLine("{0} the transaction amount  {1} exceed the limit, the transaction was sent to a manager", req.Amount, this.GetType().Name);

                NextApprover.ProcessRequest(req);
            }
        }
    }
}
