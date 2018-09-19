using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Student Akim = new Student.Student("Akim", "Lyubchenko", 4, 5, 6, 7);
            Student.Student Artem = new Student.Student("Artem", "Maklakov", 7, 8, 9, 10);
            Student.Student Nikita = new Student.Student("Nikita", "Makeychik", 3, 6, 9);

            Group.Group group2 = new Group.Group(2);
            group2.AddStudent(Akim);
            group2.AddStudent(Artem);
            group2.AddStudent(Nikita);

            System.Console.WriteLine($"AverageScore of group 2: {group2.AverageScore()}");
            System.Console.WriteLine($"AverageScore of Akim 2: {Akim.AverageScore()}");

            System.Console.ReadKey();
        }
    }
}
