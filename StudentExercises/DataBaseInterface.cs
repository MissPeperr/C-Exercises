using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;

namespace StudentExercises
{
    class DatabaseInterface
    {
        public static SqliteConnection Connection
        {
            get
            {
                string _connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(_connectionString);
            }
        }

        // public static void CheckCohortTable()
        // {
        //     SqliteConnection db = DatabaseInterface.Connection;

        //     try
        //     {
        //         List<Cohort> cohorts = db.Query<Cohort>
        //             ("SELECT Id FROM Cohort").ToList();
        //     }
        //     catch (System.Exception ex)
        //     {
        //         if (ex.Message.Contains("no such table"))
        //         {
        //             db.Execute(@"CREATE TABLE `Cohort` (
        //                 `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
        //                 `CohortName` TEXT NOT NULL
        //                 )");

        //             db.Execute(@"
        //                 INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 27');
        //                 INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 25');
        //                 INSERT INTO Cohort (CohortName) VALUES ('Day Cohort 28');
        //             ");
        //         }
        //     }
        // }

        // public static void CheckStudentTable()
        // {
        //     SqliteConnection db = DatabaseInterface.Connection;

        //     try
        //     {
        //         List<Student> students = db.Query<Student>
        //             ("SELECT Id FROM Student").ToList();
        //     }
        //     catch (System.Exception ex)
        //     {
        //         if (ex.Message.Contains("no such table"))
        //         {
        //             db.Execute(@"CREATE TABLE `Students` (
        //                 `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
        //                 `FirstName` TEXT NOT NULL,
	    //                 `LastName` TEXT NOT NULL,
        //                 `SlackHandle` TEXT NOT NULL,
        //                 `CohortID` INTEGER NOT NULL,
	    //                 FOREIGN KEY (CohortID) REFERENCES Cohort(Id)
        //             )");

        //             db.Execute(@"
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Madi', 'Peper', 'mpeper', 1);
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Jonathan', 'Edwards', 'praisebe', 1);
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Cashew', 'Agnoletti', 'cashew', 2);
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Elyse', 'Dawson', 'EDawson', 3);
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Alejandro', 'Font', 'high-waters', 1);
        //             INSERT INTO Students (FirstName, LastName, SlackHandle, CohortID)
        //             VALUES ('Kayla', 'Reid', 'kaylareid', 1);
        //             ");
        //         }
        //     }
        // }

        // public static void CheckInstructorTable()
        // {
        //     SqliteConnection db = DatabaseInterface.Connection;

        //     try
        //     {
        //         List<Instructor> instructors = db.Query<Instructor>
        //             ("SELECT Id FROM Instructor").ToList();
        //     }
        //     catch (System.Exception ex)
        //     {
        //         if (ex.Message.Contains("no such table"))
        //         {
        //             db.Execute(@"CREATE TABLE `Instructors` (
        //                 `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
        //                 `FirstName` TEXT NOT NULL,
	    //                 `LastName` TEXT NOT NULL,
        //                 `SlackHandle` TEXT NOT NULL,
        //                 `CohortID` INTEGER NOT NULL,
	    //                 FOREIGN KEY (CohortID) REFERENCES Cohort(Id)
        //             )");

        //             db.Execute(@"
        //                 INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortID)
        //                 VALUES ('Steve', 'Brownlee', 'stevebrownlee', 1);
        //                 INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortID)
        //                 VALUES ('Meg', 'Ducharme', 'megducharme', 1);
        //                 INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortID)
        //                 VALUES ('Jenna', 'Solis', 'jennasolis', 3);
        //                 INSERT INTO Instructors (FirstName, LastName, SlackHandle, CohortID)
        //                 VALUES ('Kimmy', 'Bird', 'kimmybird', 2);
        //             ");
        //         }
        //     }
        // }
        // public static void CheckExerciseTable()
        // {
        //     SqliteConnection db = DatabaseInterface.Connection;

        //     try
        //     {
        //         List<Exercise> exercises = db.Query<Exercise>
        //             ("SELECT Id FROM Exercise").ToList();
        //     }
        //     catch (System.Exception ex)
        //     {
        //         if (ex.Message.Contains("no such table"))
        //         {
        //             db.Execute(@"CREATE TABLE `Exercise` (
        //                 `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
        //                 `Name` TEXT NOT NULL,
        //                 `Language` TEXT NOT NULL
        //             )");

        //             db.Execute(@"
        //                 INSERT INTO Exercise (Name, Language) VALUES ('Lists', 'Python');
        //                 INSERT INTO Exercise (Name, Language) VALUES ('Dictionaries', 'Python');
        //                 INSERT INTO Exercise (Name, Language) VALUES ('HashSets', 'C#');
        //                 INSERT INTO Exercise (Name, Language) VALUES ('OverlyExcited', 'JavaScript');
        //                 INSERT INTO Exercise (Name, Language) VALUES ('ChickenMonkey', 'JavaScript');
        //             ");
        //         }
        //     }
        // }
    }
}