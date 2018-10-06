using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        // constructor to create new cohorts
        public Cohort (string Name)
        {
            this.Name = Name;
        }

        // the properties of the cohort
        public string Name { get; }
        public List<Instructor> InstructorList = new List<Instructor>();
        public List<Student> StudentList = new List<Student>();
    }
}