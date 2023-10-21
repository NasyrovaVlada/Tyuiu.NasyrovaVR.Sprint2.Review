using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NasyrovaVR.Sprint2.TaskReview.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((y - Math.Pow(x, 2)) > 0) && ((y - Math.Pow(Math.E, x)) < 0) && ((y - Math.Pow(Math.E, -x)) < 0))
            {
                res = true;
            }

            else
            {
                res = false;
            }
            return res;
        }
    }
}
