using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        // constructor to create new students
        public Student (string FirstName, string LastName, string SlackHandle, string CohortName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SlackHandle = SlackHandle;
            this.CohortName = CohortName;
        }

        // the properties of the student
        public string FirstName { get; }
        public string LastName { get; }
        public string SlackHandle { get; }
        public string CohortName { get; }

        public List<Exercise> ExerciseList = new List<Exercise>();
    }
}