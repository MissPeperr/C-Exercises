using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        // a constructor to create instructors
        public Instructor (string FirstName, string LastName, string SlackHandle, string CohortName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SlackHandle = SlackHandle;
            this.CohortName = CohortName;
        }

        // the properties of the instructor
        public string FirstName { get; }
        public string LastName { get; }
        public string SlackHandle { get; }
        public string CohortName { get; }

        // created a method that adds (assigns) an exercise to a student
        public void Assign(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }
    }
}