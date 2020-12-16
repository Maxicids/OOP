using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Lab9
{
    delegate int Operation(int x);
    
    class Director
    {
        public event EventHandler Promote;
        public event Action Fair;

        int salary = 500;
        public int Salary
        {
            get => salary;
            set 
            {
                if (value>0)
                {
                    salary = value;
                }
            }
        }

        Operation salaryIncrease = (x) => Convert.ToInt32(x * 1.2);
        Operation salaryDecrease = (x) => Convert.ToInt32(x * 0.8);

        public string Name = "Max";

        public void IsPromote(int hoursPerMonth)
        {
            if (hoursPerMonth > 135)
            {
                var args = new EventArgs();
                Promote?.Invoke(this, args);//проверка на null
                this.Salary = salaryIncrease(this.Salary);
            }
        }

        public void IsFair(int hoursPerMonth)
        {
            if (hoursPerMonth < 110)
            {
                Fair?.Invoke();
                this.Salary = salaryDecrease(this.Salary);
            }
        }


        public Director(int _salary, string _name)
        {
            this.Salary = _salary;
            this.Name = _name;
        }
    }
}
