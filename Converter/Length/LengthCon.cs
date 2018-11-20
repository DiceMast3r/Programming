using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length
{
    public class LengthCon
    {

        public float m, mm, nm, cm, km, microm, ft, mile;
        public float MKilo(float m)
        {
            return (m / 1000);
        }

        public float MC(float m)
        {
            return (m * 100);
        }

        public float MM(float m)
        {
            return (m * 1000);
        }

        public float MMicro(float m)
        {
            return (m * 1000000);
        }

        public float MNano(float m)
        {
            return (m * 1000000000);
        }

        public double MFt(float m)
        {
            return (m * 3.28084);
        }

        public double Mmile(float m)
        {
            return (m * 0.000621);
        }

        public  float KM(float km)
        {
            return (km / 1000);
        }

        public float CM(float cm)
        {
            return (cm / 100);
        }

        public float MilM(float mm)
        {
            return (mm / 1000);
        }

        public float MicroM(float microm)
        {
            return (microm / 1000000);
        }

        public float NanoM(float nn)
        {
            return (nn / 1000000000);
        }

        public double MileM(float mile)
        {
            return (mile / 0.000621);
        }

        public double FtM(float ft)
        {
            return (ft / 3.28084);
        }
    }
}
