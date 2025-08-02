using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задание 4
// Создайте абстрактный базовый класс Фигура с абстрактным методом для подсчета площади
// Создайте производные классы: прямоугольник, круг, прямоугольный треугольник, трапеция со своими реализациями метода для подсчета площади
// Для проверки определите массив ссылок на абстрактный класс, которым присваиваются адреса различных объектов классов-потомков

namespace Inheritance_Practice.Task_4
{
    internal abstract class Figure
    {
        public abstract double GetArea();   // Абстрактный метод
    }
}
