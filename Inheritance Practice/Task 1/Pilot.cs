using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_1
{
    internal class Pilot : Human
    {
        public string AircraftName { get; set; }
        public Pilot(string fullName, DateTime birthDate, string phoneNumber, string aircraftName) : base(fullName, birthDate, phoneNumber)
        {
            AircraftName = aircraftName;
        }

        public void Fly()
        {
            Console.WriteLine($"{FullName} пилотирует самолет {AircraftName}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Profession: pilot, Aircraft name {AircraftName}");
        }
    }
}
