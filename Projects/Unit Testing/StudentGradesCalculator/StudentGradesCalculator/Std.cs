using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentGradesCalculator
{
    public class Std
    {
        public string GetGradesByPercentage(int percentage)
        {
            if (percentage >= 90 && percentage <= 100)
            {
                return "A+";
            }
            else if (percentage >= 80 && percentage < 90)
            {
                return "A";
            }
            else if (percentage >= 70 && percentage < 80)
            {
                return "B";
            }
            else if (percentage >= 60 && percentage < 70)
            {
                return "C";
            }
            else if (percentage >= 50 && percentage < 60)
            {
                return "D";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                return "E";
            }
            else
            {
                return "Fail";
            }
        }

    }
}
