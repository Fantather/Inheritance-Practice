using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice.Task_2
{
    internal class ForeignPassport : Passport
    {
        public List<string> Visas { get; }
        public string ForeignID { get; }

        public ForeignPassport(string name, string surname, string iD, DateTime birthday, DateTime expiryDate, string foreignID)
            : base(name, surname, iD, birthday, expiryDate)
        {
            Visas = new List<string>();
            ForeignID = foreignID;
        }

        public void AddVisa(string visa) => Visas.Add(visa);
        public void RemoveVisa(string visa) => Visas.Remove(visa);
        public bool HasVisa(string visa) => Visas.Contains(visa);

        public void ShowVisas()
        {
            Console.WriteLine("Visas:");
            if(Visas.Count == 0)
            {
                Console.WriteLine(" - None");
            }

            else
            {
                foreach(string visa in Visas)
                {
                    Console.WriteLine($" - {visa}");
                }
            }
        }
    }
}
