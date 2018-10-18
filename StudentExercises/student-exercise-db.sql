CREATE TABLE Cohort (
    `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
    `CohortName` TEXT NOT NULL
);
CREATE TABLE Exercise (
    `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
    `Name` TEXT NOT NULL,
    `Language` TEXT NOT NULL
);
CREATE TABLE Instructors (
    `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
    `FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
    `SlackHandle` TEXT NOT NULL,
    `CohortID` INTEGER NOT NULL,
	FOREIGN KEY (CohortID) REFERENCES Cohort(Id)
);
CREATE TABLE Students (
    `Id` INTEGER PRIMARY KEY AUTOINCREMENT,
	`FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
    `SlackHandle` TEXT NOT NULL,
    `CohortID` INTEGER NOT NULL,
	FOREIGN KEY (CohortID) REFERENCES Cohort(Id)
);
CREATE TABLE StudentExercise (
	`Id` INTEGER PRIMARY KEY AUTOINCREMENT,
	`StudentID` INTEGER,
	`ExerciseID` INTEGER,
	FOREIGN KEY (StudentID) REFERENCES Students(Id),
	FOREIGN KEY (ExerciseID) REFERENCES Exercise(Id)
);

INSERT INTO Cohort
(CohortName)
VALUES
("Day Cohort 27")
;
INSERT INTO Cohort
(CohortName)
VALUES
("Day Cohort 25")
;
INSERT INTO Cohort
(CohortName)
VALUES
("Day Cohort 28")
;

INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Madi", "Peper", "mpeper", 1)
;
INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Jonathan", "Edwards", "praisebe", 1)
;
INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Cashew", "Agnoletti", "cashew", 2)
;
INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Elyse", "Dawson", "EDawson", 3)
;
INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Alejandro", "Font", "high-waters", 1)
;
INSERT INTO Students
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Kayla", "Reid", "kaylareid", 1)
;

INSERT INTO Instructors
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Steve", "Brownlee", "stevebrownlee", 1)
;
INSERT INTO Instructors
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Meg", "Ducharme", "megducharme", 1)
;
INSERT INTO Instructors
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Jenna", "Solis", "jennasolis", 3)
;
INSERT INTO Instructors
(FirstName, LastName, SlackHandle, CohortID)
VALUES
("Kimmy", "Bird", "kimmybird", 2)
;

INSERT INTO Exercise
(Name, Language)
VALUES
("Lists", "Python")
;
INSERT INTO Exercise
(Name, Language)
VALUES
("Dictionaries", "Python")
;
INSERT INTO Exercise
(Name, Language)
VALUES
("HashSets", "C#")
;
INSERT INTO Exercise
(Name, Language)
VALUES
("OverlyExcited", "JavaScript")
;
INSERT INTO Exercise
(Name, Language)
VALUES
("ChickenMonkey", "JavaScript")
;