using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_And_Expenses_agen
{
    internal class INE
    {
        public string alldata = string.Empty;
        private string textboxDate = string.Empty;
        private string textBox2 = string.Empty;
        private string textBox3 = string.Empty;
        private string textBox4 = string.Empty;
        private string textBox5 = string.Empty;


        public void INEdata(string Date, string List, string Type, string Income, string Expenses)
        {
            this.alldata += Date +", " + List + ", " + Type + ", " + Income + ", " + Expenses + "\r\n";
            this.textboxDate = Date;
            this.textBox2 = List;
            this.textBox4 = Income;
            this.textBox5 = Expenses;

        }

        public string getAllINEdata()
        {
            return alldata;
        }
    }
}
