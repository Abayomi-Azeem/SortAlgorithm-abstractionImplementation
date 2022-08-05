using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program1 : IFootballClubRules
    {
        public string[] ClubEmplyees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClubName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] Investors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double NetIncome(double empSalary, double earnings)
        {
            return 1;
        }

        public bool PLayersAvailable()
        {
            return true;
        }
    }

    internal class Program2 : FootballClubsRules
    {
        public override string[] ClubEmplyees { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ClubName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string[] Investors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double NetIncome(double empSalary, double earnings)
        {
            return 0;
        }

        public override bool PLayersAvailable()
        {
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] strings)
        {
            var abstractionInterface = new Program1();
            var abstractionClass = new Program2();
            Console.WriteLine("Abstraction Using interface "+abstractionInterface.NetIncome(2000, 350));
            Console.WriteLine("Abstraction Using interface " + abstractionInterface.PLayersAvailable());
            Console.WriteLine();
            Console.WriteLine("Abstraction Using Abstraction Class " + abstractionClass.NetIncome(2000, 350));
            Console.WriteLine("Abstraction Using Abstraction Class " + abstractionClass.PLayersAvailable());

        }
    }
}
