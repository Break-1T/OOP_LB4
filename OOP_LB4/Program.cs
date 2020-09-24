using System;
using System.Diagnostics;
using System.Reflection;
using OOP_LB4._1st;

namespace OOP_LB4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-е Задание
            Debug.WriteLine(new string('-', 30));
            Debug.WriteLine("1-е Задание:");

            Human human = new Human("Ivan","Yakovich","Male",28);
            Debug.WriteLine($"This is class {human.GetType().Name}");
            human.Info();

            Employee employee = new Employee("Taras","Krupko","Male",18,"Director",18785);
            Debug.WriteLine($"This is class {employee.GetType().Name}");
            employee.Info();

            Human human1 = (Human)employee;
            Debug.WriteLine($"This is class {human1.GetType().Name}");
            human1.Info();

            Employee employee1 = (Employee)human1;
            Debug.WriteLine($"This is class {employee1.GetType().Name}");
            employee1.Info();
            Debug.WriteLine(new string('-',30));
            #endregion
        }
    }
}

