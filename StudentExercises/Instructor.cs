using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public Instructor (string FirstName, string LastName, string SlackHandle, string CohortName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SlackHandle = SlackHandle;
            this.CohortName = CohortName;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public string SlackHandle { get; }
        public string CohortName { get; }

        // need a method to assign an exercise to a student ?????

        public void Assign(Student student, Exercise exercise)
        {
            student.ExerciseList.Add(exercise);
        }
    }
}