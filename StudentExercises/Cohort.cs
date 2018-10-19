using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        // a parameterless constructor for Dapper to use
        public Cohort(){}
        // constructor to create new cohorts
        public Cohort (string Name)
        {
            this.Name = Name;
        }

        // the properties of the cohort
        public int Id { get; }
        public string Name { get; }
        // for the purpose of student exercise part 4, added 'CohortName'
        public string CohortName { get; set; }
        public List<Instructor> InstructorList = new List<Instructor>();
        public List<Student> StudentList = new List<Student>();
    }
}