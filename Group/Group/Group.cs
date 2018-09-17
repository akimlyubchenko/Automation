using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group
{
    /// <summary>
    /// The group description
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Gets the number of group
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// The students
        /// </summary>
        public List<Student.Student> students = new List<Student.Student>();

        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="number">The number of group</param>
        /// <exception cref="ArgumentException">The group number must be greater than 0</exception>
        public Group(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The group number must be greater than 0"); 
            }

            Number = number;
        }

        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="number">The number of group</param>
        /// <param name="students">The students</param>
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

        /// <summary>
        /// Averages scrore computer
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Adds the student.
        /// </summary>
        /// <param name="student">The student.</param>
        public void AddStudent(Student.Student student)
        {
            students.Add(student);
        }
    }
}
