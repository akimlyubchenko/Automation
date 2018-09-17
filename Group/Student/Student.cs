using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    /// <summary>
    /// The student description
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets the first name
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets the last name
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// The notes
        /// </summary>
        private List<int> notes = new List<int>();

        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
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

        /// <summary>
        /// Initializes a new instance
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="notes">The notes.</param>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Averages score computer
        /// </summary>
        /// <returns></returns>
        public double AverageScore()
            => notes.Average();

        /// <summary>
        /// Adds the note
        /// </summary>
        /// <param name="note">The note</param>
        public void AddNote(int note)
            => notes.Add(note);
    }
}
