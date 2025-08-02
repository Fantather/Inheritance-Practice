using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_1
{
    internal class Sailor : Human
    {
        public string VesselName { get; set; }
        public Sailor(string fullName, DateTime birthDate, string phoneNumber, string vesselName) : base(fullName, birthDate, phoneNumber)
        {
            VesselName = fullName;
        }

        public string Sail()
        {
            return $"{FullName} controls the vessel {VesselName}";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Profession: sailor, Vessel: {VesselName}");
        }
    }
}
