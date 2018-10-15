using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        // constructor to create new students
        public Student (string FirstName, string LastName, string SlackHandle, string Cohort)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SlackHandle = SlackHandle;
            this.Cohort = Cohort;
        }

        // the properties of the student
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }
        public string SlackHandle { get; }
        public string Cohort { get; }

        public List<Exercise> ExerciseList = new List<Exercise>();
    }
}