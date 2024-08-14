using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class ptb2
    {
        double a, b, c;

        public ptb2(double a = 1, double b = 0 , double c = 0)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string giaipt()
        {
            string s = "";
            double d = b * b + 4 * a * c;
            if (d < 0) s = "pt vo nghiem";
            if (d == 0) s = "x1 = x2 = " + ((-b) / (2 * a)).ToString();
            if(d > 0)
            {
                double x1, x2; 
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                s = "x1 = " + x1.ToString()+
                    "\nx2 = " + x2.ToString();
            }
            return s;
        }
    }
}
