using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_And_Expenses
{
    internal class Data
    {
        public string Income;
        public string Expenses;
        public string List;

        public Data(string income,
            string Expenses,
            string list)
        {
            this.Income = income;
            this.Expenses = Expenses;
            this.List = list;

        }
        public string getIncome() { return this.Income; }
        public string getExpenses() { return this.Expenses; }
        public string getList() { return this.List; }

    }

}
