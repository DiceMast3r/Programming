using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class TimeCon
    {
        public float s, m, h, day; 

        public float HS(float h)
        {
            return h * 3600;
        }

        public float HM(float h)
        {
            return h * 60;
        }

        public float DS(float day)
        {
            return day * 86400;
        }

        public float DM(float day)
        {
            return day * 1440;
        }

        public float SH(float s)
        {
            return s / 3600;
        }

        public float MH(float m)
        {
            return m / 60;
        }

        public float SD(float s)
        {
            return s / 86400;
        }

        public float MD(float m)
        {
            return m / 1440;
        }
    }
}
