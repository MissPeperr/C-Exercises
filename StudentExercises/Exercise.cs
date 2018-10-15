using System;

namespace StudentExercises
{
    class Exercise
    {
        // constructor to create exercises
        public Exercise (string Name, string Language)
        {
            this.Name = Name;
            this.Language = Language;
        }
        
        // the properties of the exercise
        public string Name { get; }
        public string Language { get; }
    }
}