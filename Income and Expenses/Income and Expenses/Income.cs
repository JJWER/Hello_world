using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_and_Expenses
{
    internal class Income
    {
        private string _date;
        private int Income_Sum;

        public Income(string date,
            string v,
            int Income_sum)
        {
            this._date = date;
            this.Income_Sum = Income_sum;
        }

        public Income(char v1, char v2, char v3)
        {
        }

        public string getDate() { return this._date; }

        public int getIncome_sum() { return this.Income_Sum; }

    }
}


