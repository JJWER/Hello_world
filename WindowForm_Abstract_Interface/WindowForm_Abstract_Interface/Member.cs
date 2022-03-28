using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm_Abstract_Interface
{
    internal abstract class Member
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public abstract bool register();
    }
}
