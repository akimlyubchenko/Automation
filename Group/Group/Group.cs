using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    public class Group
    {
        public int Number { get; private set; }
        public List<Student.Student> students = new List<Student.Student>();

        public Group(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The group number must be greater than 0"); 
            }

            Number = number;
        }
        
        public Group(int number, params Student.Student[] students) : this(number)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    this.students.Add(students[i]);
                }
            }
        }

        public double AverageScore()
        {
            double avScore = 0;
            int count = 0;

            foreach (var student in students)
            {
                avScore += student.AverageScore();
                count++;
            }

            return avScore / count;
        }

        public void AddStudent(Student.Student student)
        {
            students.Add(student);
        }
    }
}
