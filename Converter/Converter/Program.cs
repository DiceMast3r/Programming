using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Length;
using Time;
using Temperature;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Converter =====");
            Menu();
        }

        static void Menu()
        {
            Console.Write("Press 1 for length\n");
            Console.Write("Press 2 for time\n");
            Console.Write("Press 3 for temperature\n");
            Console.Write("Press 00 to exit\n");
            Console.Write("Select: ");
            int.TryParse(Console.ReadLine(), out int msel);
            if (msel == 00)
            {
                Console.WriteLine("Program is Exiting!!!");
                Thread.Sleep(750);
                Environment.Exit(0);
            }
            if (msel == 1)
            {
                Length();
            }
            if (msel == 2)
            {
                Time();
            }
            if (msel == 3)
            {
                Temperature();
            }
        }

        static void Length()
        {
            Console.WriteLine("=====Length=====");
            Console.Write("Press 1 form Meters to Kilometers\n");
            Console.Write("Press 2 form Meters to Centimeters\n");
            Console.Write("Press 3 form Meters to Millimeters\n");
            Console.Write("Press 4 form Meters to Micrometers\n");
            Console.Write("Press 5 form Meters to Nanometers\n");
            Console.Write("Press 6 form Meters to Miles\n");
            Console.Write("Press 7 form Meters to Feet\n");
            Console.Write("Press 18 form Kilometers to Meters\n");
            Console.Write("Press 28 form Centimeters to Meters\n");
            Console.Write("Press 38 form Millimeters to Meters\n");
            Console.Write("Press 48 form Micrometers to Meters\n");
            Console.Write("Press 58 form Nanometers to Meters\n");
            Console.Write("Press 68 form Miles to Meters\n");
            Console.Write("Press 78 form Feet to Meters\n");
            Console.Write("Press 03 to goto Menu\n");
            Console.Write("Select: ");
            int.TryParse(Console.ReadLine(), out int lsel);
            if (lsel == 03)
            {
                Menu();
            }
            if (lsel == 1)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MKilo(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 2)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MC(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 3)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MM(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 4)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MMicro(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 5)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MNano(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 6)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.Mmile(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 7)
            {
                Console.Write("Enter length in meters: ");
                float.TryParse(Console.ReadLine(), out float m);
                LengthCon lengthCon = new LengthCon();
                lengthCon.m = m;
                Console.WriteLine("Ans: {0}", lengthCon.MFt(m));
                Console.WriteLine();
                Length();
            }
            if (lsel == 18)
            {
                Console.Write("Enter length in kilometers: ");
                float.TryParse(Console.ReadLine(), out float km);
                LengthCon lengthCon = new LengthCon();
                lengthCon.km = km;
                Console.WriteLine("Ans: {0}", lengthCon.KM(km));
                Console.WriteLine();
                Length();
            }
            if (lsel == 28)
            {
                Console.Write("Enter length in centimeters: ");
                float.TryParse(Console.ReadLine(), out float cm);
                LengthCon lengthCon = new LengthCon();
                lengthCon.cm = cm;
                Console.WriteLine("Ans: {0}", lengthCon.CM(cm));
                Console.WriteLine();
                Length();
            }
            if (lsel == 38)
            {
                Console.Write("Enter length in millimeters: ");
                float.TryParse(Console.ReadLine(), out float mm);
                LengthCon lengthCon = new LengthCon();
                lengthCon.mm = mm;
                Console.WriteLine("Ans: {0}", lengthCon.MilM(mm));
                Console.WriteLine();
                Length();
            }
            if (lsel == 48)
            {
                Console.Write("Enter length in micrometers: ");
                float.TryParse(Console.ReadLine(), out float micro);
                LengthCon lengthCon = new LengthCon();
                lengthCon.microm = micro;
                Console.WriteLine("Ans: {0}", lengthCon.MicroM(micro));
                Console.WriteLine();
                Length();
            }
            if (lsel == 58)
            {
                Console.Write("Enter length in nanometers: ");
                float.TryParse(Console.ReadLine(), out float nm);
                LengthCon lengthCon = new LengthCon();
                lengthCon.nm = nm;
                Console.WriteLine("Ans: {0}", lengthCon.NanoM(nm));
                Console.WriteLine();
                Length();
            }
            if (lsel == 68)
            {
                Console.Write("Enter length in miles: ");
                float.TryParse(Console.ReadLine(), out float mile);
                LengthCon lengthCon = new LengthCon();
                lengthCon.mile = mile;
                Console.WriteLine("Ans: {0}", lengthCon.MileM(mile));
                Console.WriteLine();
                Length();
            }
            if (lsel == 78)
            {
                Console.Write("Enter length in feet: ");
                float.TryParse(Console.ReadLine(), out float ft);
                LengthCon lengthCon = new LengthCon();
                lengthCon.ft = ft;
                Console.WriteLine("Ans: {0}", lengthCon.FtM(ft));
                Console.WriteLine();
                Length();
            }
        }

        static void Time()
        {
            Console.WriteLine("=====Time=====");
            Console.Write("Press 1 form Hours to Second\n");
            Console.Write("Press 2 form Hours to Minutes\n");
            Console.Write("Press 3 form Days to Second\n");
            Console.Write("Press 4 form Days to Minutes\n");
            Console.Write("Press 15 form Second to Hours\n");
            Console.Write("Press 25 form Minutes to Hours\n");
            Console.Write("Press 35 form Second to Days\n");
            Console.Write("Press 45 form Minutes to Days\n");
        }

        static void Temperature()
        {
            Console.WriteLine("=====Temperature=====");
            Console.Write("Press 1 form Celsius to Fahrenheit\n");
            Console.Write("Press 2 from Celsius to Kelvin\n");
            Console.Write("Press 3 from Fahrenheit to Celsius\n");
            Console.Write("Press 4 from Fahrenheit to Kelvin\n");
            Console.Write("Press 5 from Kelvin to Celsius\n");
            Console.Write("Press 6 from Kelvin to Fahrenheit\n");
        }


    }
}
