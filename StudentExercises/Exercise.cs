using System;

namespace StudentExercises
{
    class Exercise
    {
        // a parameterless constructor for Dapper to use
        public Exercise(){}
        // constructor to create exercises
        public Exercise (string Name, string Language)
        {
            this.Name = Name;
            this.Language = Language;
        }

        
        // the properties of the exercise
        public int Id { get; }
        public string Name { get; }
        public string Language { get; }
    }
}