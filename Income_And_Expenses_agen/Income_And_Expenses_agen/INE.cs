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
        private string textBox2 = string.Empty;
        private string textBox3 = string.Empty;
        private string comboBox1 = string.Empty;

        public void addGPA(string List, string Type, string Count)
        {
            this.alldata += List + ", " + Type + ", " + Count + "\r\n";
            this.textBox2 = List;
            this.textBox3 = Count;
            this.comboBox1 = Type;

        }


        public string getAlldata()
        {
            return alldata;
        }
    }
}
