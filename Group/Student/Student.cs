using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        private List<int> notes = new List<int>();

        public Student(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException($"Invalid name {firstName}");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException($"Invalid name {lastName}");
            }

            FirstName = firstName;
            LastName = lastName;
        }

        public Student(string firstName, string lastName, params int[] notes) :this(firstName, lastName)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] < 1 && notes[i] > 10)
                {
                    throw new ArgumentException($"Invalid note {notes[i]}");
                }

                this.notes.Add(notes[i]);
            }
        }

        public double AverageScore()
            => notes.Average();

        public void AddNote(int note)
            => notes.Add(note);
    }
}
