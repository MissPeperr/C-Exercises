using System;

namespace StudentExercises
{
    class Exercise
    {
        public Exercise (string Name, string Language)
        {
            this.Name = Name;
            this.Language = Language;
        }
        public string Name { get; }
        public string Language { get; }
    }
}