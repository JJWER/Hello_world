using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses_And_Income
{
    internal class Data
    {
        public string alldata = string.Empty;
        private string textBox2 = string.Empty;
        private string textBox3 = string.Empty;
        private string comboBox1 = string.Empty;

        public void addGPA(string _list, string _type, string _count)
        {
            this.alldata += _list + ", " + _type + ", " + _count + "\r\n";
            this.textBox2 = _list;
            this.textBox3 = _count;
            this.comboBox1 = _type;

        }


        public string getAlldata()
        {
            return alldata;
        }

    }


}
