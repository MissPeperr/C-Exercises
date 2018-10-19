using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        // a parameterless constructor for Dapper to use
        public Instructor(){}

        // a constructor to create instructors
        public Instructor (string FirstName, string LastName, string SlackHandle, string CohortName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SlackHandle = SlackHandle;
            this.CohortName = CohortName;
        }

        // the properties of the instructor
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string CohortName { get; set; }

        public int CohortID { get; set; }

        // created a method that dds (assigns) an exercise to a student
        public void Assign(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }
    }
}