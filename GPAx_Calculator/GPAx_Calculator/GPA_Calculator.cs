using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAx_Calculator
{
    internal class GPA_Calculator
    {
        double sum = 0;
        int n = 0;
        double max = 0; 
        void addGPA(double gpa)
        {
            this.sum += gpa;
            this.n++;
        }

        void addGPAX() {
            double result = this.sum / this.n;
            return result;
        }
    }
}
