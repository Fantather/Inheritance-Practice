using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание 1
// Создайте класс Human, который будет содержать информацию о человеке
// С помощью механизма наследования, реализуйте класс Builder (содержит информацию о строителе),
// класс Sailor (содержит информацию о моряке),
// класс Pilot (содержит информацию о летчике)
// Каждый из классов должен содержать необходимые для работы методы

namespace Inheritance_Practice.Task_1
{
    internal class Human
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }

        public Human(string fullName, DateTime birthDate, string phoneNumber)
        {
            FullName = fullName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Full name: {FullName}, Birth date: {BirthDate}, Phone number: {PhoneNumber}");
        }
    }
}
