using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>();
            List<Exercise> AllExercises = new List<Exercise>();
            /*
                Create 4, or more, exercises.
                Create 3, or more, cohorts.
                Create 4, or more, students and assign them to one of the cohorts.
                Create 3, or more, instructors and assign them to one of the cohorts.
                Have each instructor assign 2 exercises to each of the students.
            */

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

            // assign exercises to students
            Steve.Assign(Madi, Classes);
            Steve.Assign(Madi, HashSets);
            Meg.Assign(Jonathan, Classes);
            Meg.Assign(Jonathan, HashSets);
            Jenna.Assign(Elyse, Classes);
            Jenna.Assign(Elyse, Lists);
            Steve.Assign(Madi, Dictionaries);
            
            // added students to the student list that was created
            StudentList.Add(Madi);
            StudentList.Add(Jonathan);
            StudentList.Add(Cashew);
            StudentList.Add(Elyse);

            // added exercises to the exercise list that was created
            AllExercises.Add(Classes);
            AllExercises.Add(Lists);
            AllExercises.Add(Dictionaries);
            AllExercises.Add(HashSets);

            Console.WriteLine($"Testing ExerciseList in Student: {Madi.ExerciseList}");
            Console.WriteLine($"Testing Exercises: {AllExercises.Dictionaries.Name}");

            // foreach(Student student in StudentList)
            // {
            //     foreach(Exercise exercise in AllExercises)
            //     {
            //         if(student.ExerciseList ==)
            //         {
            //         Console.WriteLine($"{student.FirstName} is currently working on {exercise}");
            //         }
            //     }
            // }
        }
    }
}
