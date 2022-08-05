using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public abstract class FootballClubsRules
    {
         public abstract string[] ClubEmplyees { get; set; }
        public abstract string ClubName { get; set; }
        public abstract string[] Investors { get; set; }

        public abstract double NetIncome(double empSalary, double earnings);


        public abstract bool PLayersAvailable();
}

}
