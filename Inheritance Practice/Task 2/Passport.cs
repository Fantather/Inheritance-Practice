using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание 2
// Создайте класс Passport (паспорт), который будет содержать паспортную информацию о гражданине заданной страны
// С помощью механизма наследования, реализуйте класс ForeignPassport (загранпаспорт) производный от Passport
// Напомним, что заграничный паспорт содержит помимо паспортных данных, также данные о визах, номер заграничного паспорта
// Каждый из классов должен содержать необходимые методы

namespace Inheritance_Practice.Task_2
{
    internal class Passport
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string ID { get; }
        public DateTime BirthDay { get; }
        public DateTime ExpiryDate { get; }

        public Passport(string name, string surname, string iD, DateTime birthday, DateTime expiryDate)
        {
            Name = name;
            Surname = surname;
            ID = iD;
            BirthDay = birthday;
            ExpiryDate = expiryDate;
        }

        public void ChangeName(string newName) => Name = newName;
        public void ChangeSurname(string newSurname) => Surname = newSurname;
        public bool IsExpired() => DateTime.Now > ExpiryDate;
    }
}
