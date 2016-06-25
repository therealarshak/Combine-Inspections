using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Console.WriteLine("What is NA?");
            int NA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is NB?");
            int NB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is NC?");
            int NC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is ND?");
            int ND = Convert.ToInt32(Console.ReadLine());

            
            //Tot Insp Variable
            double totinsp = NA * 4 + NB * 2 + NC * 1 + ND * 0.5;

            
            //Tot Insp Code
            if (totinsp == 0)
            {
                Console.WriteLine("1E");
            }
            if (totinsp >= 0.5 && totinsp < 1)
            {
                Console.WriteLine("1D");
            }
            if (totinsp >= 1 && totinsp < 2)
            {
                Console.WriteLine("1C");
            }
            if (totinsp >= 2 && totinsp < 4)
            {
                Console.WriteLine("1B");
            }
            if (totinsp >= 4 && totinsp < 8)
            {
                Console.WriteLine("1A");
            }
            if (totinsp >=8 && totinsp < 12)
            {
                Console.WriteLine("2A");
            }
            if (totinsp >= 12 && totinsp < 16)
            {
                Console.WriteLine("3A");
            }
            if (totinsp >= 16 && totinsp < 20)
            {
                Console.WriteLine("4A");
            }
            if (totinsp >= 20 && totinsp < 24)
            {
                Console.WriteLine("5A");
            }
            if (totinsp >= 24)
            {
                Console.WriteLine("6A");
            }
        }
    }
}
