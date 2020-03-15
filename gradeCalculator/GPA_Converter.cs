using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeCalculator
{
    class GPA_Converter
    {
        private double number
            ;
        private bool weighted;

        public GPA_Converter(double aNumber, bool aWeighted)
        {
            number = aNumber;
            weighted = aWeighted;
        }

        public double getNumber()
        {
            return number; 
        }
        public void calculate(double x)
        {
            if (x >= 96.5 && weighted)
            {
                number = 5.33;
            }

            else if (x >= 96.5 && !weighted)
            {
                number = 4.33;
            }

            else if (x >= 92.5 && weighted)
            {
                number = 5.00;
            }

            else if (x >= 92.5 && !weighted)
            {
                number = 4.00;
            }

            else if (x >= 89.5 && weighted)
            {
                number = 4.67;
            }

            else if (x >= 89.5 && !weighted)
            {
                number = 3.67;
            }



            else if (x >= 86.5 && weighted)
            {
                number = 4.33;
            }

            else if (x >= 86.5 && !weighted)
            {
                number = 3.33;
            }


            else if (x >= 82.5 && weighted)
            {
                number = 4.00;
            }

            else if (x >= 82.5 && !weighted)
            {
                number = 3.00;
            }

            else if (x >= 79.5)
            {
                number = 2.67;
            }

            else if (x >= 76.5)
            {
                number = 2.33;
            }

            else if (x >= 72.5)
            {
                number = 2.00;
            }

            else if (x >= 69.5)
            {
                number = 1.67;
            }

            else if (x >= 66.5)
            {
                number = 1.33;
            }

            else if (x >= 62.5)
            {
                number = 1.00;
            }

            else if (x >= 59.5)
            {
                number = 0.67;
            }

            else
            {
                number = 0.00;
            }
        }
    }
}
