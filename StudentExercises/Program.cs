using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

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
            Exercise OverlyExcited = new Exercise("OverlyExcited", "JavaScript");
            Exercise ChickenMonkey = new Exercise("ChickenMonkey", "JavaScript");

            // created 3 cohorts
            Cohort TwentySeven = new Cohort("Day Cohort 27");
            Cohort TwentyEight = new Cohort("Day Cohort 28");
            Cohort TwentyFive = new Cohort("Day Cohort 25");

            // created 4 students
            Student Madi = new Student("Madi", "Peper", "MadiPeper", TwentySeven.Name);
            Student Jonathan = new Student("Jonathan", "Edwards", "PraiseBe", TwentySeven.Name);
            Student Cashew = new Student("Cashew", "Agnoletti", "Cashew", TwentyFive.Name);
            Student Elyse = new Student("Elyse", "Dawson", "ElyseDawson", TwentyEight.Name);
            Student Alejandro = new Student("Alejandro", "Font", "high-waters", TwentySeven.Name);
            Student Kayla = new Student("Kayla", "Reid", "k.reid", TwentySeven.Name);

            // created 3 instructors
            Instructor Steve = new Instructor("Steve", "Brownlee", "stevebrownlee", TwentySeven.Name);
            Instructor Meg = new Instructor("Meg", "Ducharme", "megducharme", TwentySeven.Name);
            Instructor Jenna = new Instructor("Jenna", "Solis", "JennaSolis", TwentyEight.Name);

            // assign 2 exercises to 3 students
            Steve.Assign(Madi, Classes);
            Steve.Assign(Madi, HashSets);
            Steve.Assign(Madi, OverlyExcited);
            Meg.Assign(Madi, ChickenMonkey);
            Meg.Assign(Jonathan, Classes);
            Meg.Assign(Jonathan, HashSets);
            Meg.Assign(Jonathan, ChickenMonkey);
            Jenna.Assign(Elyse, Classes);
            Jenna.Assign(Elyse, Lists);

            List<Student> StudentList = new List<Student>(){
            // added students to the student list that was created
                Madi, Jonathan, Cashew, Elyse
            };

            List<Exercise> AllExercises = new List<Exercise>(){
            // added exercises to the exercise list that was created
                Classes, Lists, Dictionaries, HashSets
            };

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

            /*
                ☑️ 1. List exercises for the JavaScript language by using the Where() LINQ method.
                ☑️ 2. List students in a particular cohort by using the Where() LINQ method.
                ☑️ 3. List instructors in a particular cohort by using the Where() LINQ method.
                ☑️ 4. Sort the students by their last name.
                ☑️ 5. Display any students that aren't working on any exercises (Make sure one of your student          instances don't have any exercises. Create a new student if you need to.)
                ☑️ 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
                ☑️ 7. How many students in each cohort?
            */

            Console.WriteLine("////////// Student Exercise Pt. 2 //////////");
            List<Student> students = new List<Student>(){
                Madi, Jonathan, Cashew, Elyse, Kayla, Alejandro
            };
            List<Instructor> instructors = new List<Instructor>(){
                Steve, Jenna, Meg
            };
            List<Exercise> exercises = new List<Exercise>(){
                Classes, Lists, Dictionaries, HashSets, ChickenMonkey, OverlyExcited
            };
            List<Cohort> cohorts = new List<Cohort>(){
                TwentyEight, TwentySeven, TwentyFive
            };

            Console.WriteLine("///// JavaScript Exercises /////");
            List<Exercise> JSExercises = (from e in exercises
                where e.Language.Contains("JavaScript")
                select e).ToList();
            JSExercises.ForEach(e => Console.WriteLine(e.Name));

            Console.WriteLine("///// Students in 27 /////");
            List<Student> TwentySevenStudents = (from s in students
                where s.Cohort.Contains("27")
                select s).ToList();
            TwentySevenStudents.ForEach(s => Console.WriteLine(s.FullName));

            Console.WriteLine("///// Instructors in 27 /////");
            List<Instructor> TwentySevenInstructors = (from i in instructors
                where i.CohortName.Contains("27")
                select i).ToList();
            TwentySevenInstructors.ForEach(i => Console.WriteLine(i.FirstName));

            Console.WriteLine("///// Sort Students by Last Name /////");
            List<Student> lastNames = (from s in students
                orderby s.LastName ascending
                select s).ToList();
            lastNames.ForEach(s => Console.WriteLine(s.FullName));

            Console.WriteLine("///// Students w/o Exercise /////");
            List<Student> noExercises = (from s in students
                where s.ExerciseList.Count() == 0
                select s).ToList();
            noExercises.ForEach(student => Console.WriteLine($"{student.FirstName} does not have an exercise!"));

            Console.WriteLine("///// Most Exercises per Student /////");
            List<Student> mostExercises = (from s in students
                orderby s.ExerciseList.Count() descending
                select s).ToList();
            Console.WriteLine($"{mostExercises.First().FirstName} has the most exercises.");

            Console.WriteLine("///// How many students per Cohort? /////");
            // using var here because it is making an anonymous object
            var totalStudents = from student in students
                group student by student.Cohort into sortedStudents
                select new {Cohort = sortedStudents.Key, Students = sortedStudents.ToList()};

            foreach (var total in totalStudents)
            {
                Console.WriteLine($"Cohort {total.Cohort} has {total.Students.Count()} students.");
            }

            Console.WriteLine("////////// Students Exercise Pt. 4 //////////");
            SqliteConnection db = DatabaseInterface.Connection;
            // DatabaseInterface.CheckCohortTable();
            // DatabaseInterface.CheckStudentTable();
            // DatabaseInterface.CheckInstructorTable();
            // DatabaseInterface.CheckExerciseTable();

            // List<Exercise> DBexercises = db.Query<Exercise>(@"SELECT * FROM Exercise").ToList();
            // exercises.ForEach(exer => Console.WriteLine($"{exer.Name}"));
            db.Query<Exercise>(@"SELECT * FROM Exercise")
              .ToList()
              .ForEach(exer => Console.WriteLine($"{exer.Name}"));

        }
    }
}

