using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public Cohort (string Name)
        {
            this.Name = Name;
        }
        public string Name { get; }

        public List<Instructor> InstructorList = new List<Instructor>();
        public List<Student> StudentList = new List<Student>();
    }
}