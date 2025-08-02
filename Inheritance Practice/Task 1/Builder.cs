using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_1
{
    internal class Builder : Human
    {
        public string Specialty { get; set; }

        public Builder(string fullName, DateTime birthDate, string phoneNumber, string specialty)
            : base(fullName, birthDate, phoneNumber)
        {
            Specialty = specialty;
        }

        public string Build(string structure)
        {
            return $"Builder {FullName} builds {structure} as {Specialty}";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Profession: builder, Speciality: {Specialty}");
        }
    }
}
