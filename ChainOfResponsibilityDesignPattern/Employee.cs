using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee employee)
        {
            NextApprover = employee;
        }
        public abstract void ProcessRequest(MoneyWithdraw req);
    }
}
