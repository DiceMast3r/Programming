using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    public class TempCon
    {
        public double c, f, k;

        public double CF(float c)
        {
            return (c * 1.8) + 32;
        }

        public double CK(float c)
        {
            return c + 273.15;
        }

        public double FC(float f)
        {
            return (f / 1.8) + 32;
        }

        public double FK(float f)
        {
            return (f + 459.67) / 0.55555;
        }

        public double KC(float k)
        {
            return k - 273.15;
        }

        public double KF(float k)
        {
            return (k * 1.8) - 459.67;
        }
    }
}
