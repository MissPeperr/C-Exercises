using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // created 4 exercises
            Exercise Classes = new Exercise("Classes", "C#");
            Exercise Lists = new Exercise("Lists", "Python");
            Exercise Dictionaries = new Exercise("Dictionaries", "Python");
            Exercise HashSets = new Exercise("HashSets", "C#");

            // created 3 cohorts
            Cohort TwentySeven = new Cohort("Day Cohort 27");
            Cohort TwentyEight = new Cohort("Day Cohort 28");
            Cohort TwentyFive = new Cohort("Day Cohort 25");

            // created 4 students
            Student Madi = new Student("Madi", "Peper", "MadiPeper", TwentySeven.Name);
            Student Jonathan = new Student("Jonathan", "Edwards", "PraiseBe", TwentySeven.Name);
            Student Cashew = new Student("Cashew", "Angoletti", "Cashew", TwentyFive.Name);
            Student Elyse = new Student("Elyse", "Dawson", "ElyseDawson", TwentyEight.Name);

            // created 3 instructors
            Instructor Steve = new Instructor("Steve", "Brownlee", "stevebrownlee", TwentySeven.Name);
            Instructor Meg = new Instructor("Meg", "Ducharme", "megducharme", TwentySeven.Name);
            Instructor Jenna = new Instructor("Jenna", "Solis", "JennaSolis", TwentyEight.Name);

            // assign 2 exercises to 3 students
            Steve.Assign(Madi, Classes);
            Steve.Assign(Madi, HashSets);
            Meg.Assign(Jonathan, Classes);
            Meg.Assign(Jonathan, HashSets);
            Jenna.Assign(Elyse, Classes);
            Jenna.Assign(Elyse, Lists);
            
            List<Student> StudentList = new List<Student>();
            // added students to the student list that was created
            StudentList.Add(Madi);
            StudentList.Add(Jonathan);
            StudentList.Add(Cashew);
            StudentList.Add(Elyse);

            List<Exercise> AllExercises = new List<Exercise>();
            // added exercises to the exercise list that was created
            AllExercises.Add(Classes);
            AllExercises.Add(Lists);
            AllExercises.Add(Dictionaries);
            AllExercises.Add(HashSets);

            // loop through the list of students
            foreach(Student student in StudentList)
            {
                // loop through the list of exercises
                foreach(Exercise exercise in AllExercises)
                {
                    /*
                        If the student's exercise list contains the current exercise, then print the student's first name and the exercise they're working on
                    */
                    if(student.ExerciseList.Contains(exercise))
                    {
                        Console.WriteLine($"{student.FirstName} is currently working on {exercise.Name}");
                    }

                }
            }
        }
    }
}
