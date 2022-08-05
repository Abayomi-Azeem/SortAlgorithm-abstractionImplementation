using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal interface IFootballClubRules
    {
        public string[] ClubEmplyees { get; set; }
        public string ClubName { get; set; }   
        public string[] Investors { get; set; }

        public double NetIncome(double empSalary, double earnings);


        public bool PLayersAvailable();

    }
}
