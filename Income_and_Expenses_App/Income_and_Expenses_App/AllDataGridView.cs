using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_and_Expenses_App
{
    internal class AllDataGridView
    {
        public int Income { get; set; }
        public int Expenses { get; set; }
        public int Sum_Income { get; set; }
        public int Sum_Expenses { get; set; }
        public string ListItem { get; set; }
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;

        public AllDataGridView(string v,
            int income,
            int expenses,
            int sum_income,
            int sum_expenses)
        {
            this.Income = income;
            this.Expenses = expenses;
            this.Sum_Income = sum_income;
            this.Sum_Expenses = sum_expenses;
        }

        public AllDataGridView(string v1, string v2, string v3, string v4, string v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        //public int getIncome() { return this.Income; }
        //public int getExpenses() { return this.Expenses; }
        //public int getSum_Income() { return this.Sum_Income; }
    }
}
