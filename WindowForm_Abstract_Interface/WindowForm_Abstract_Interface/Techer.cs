using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowForm_Abstract_Interface
{
    internal class Techer : Member, Keynote
    {
        public bool approveCourse()
        {
            return true;
        }
        public override bool register()
        {
            return true;
        }

        public bool train()
        {
            return false;
        }
    }
}
