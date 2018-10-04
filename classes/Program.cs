using System;
using System.Collections.Generic;

public class Employee {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName {
        get 
        {
            return string.Format($"{FirstName} {LastName}");
        }
    }
    public string Title { get; set; }
    public DateTime StartDate { get; }
    
    public void ListEmployees(Employee employee)
    {
        Console.WriteLine(FullName);
    }
}
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public static List<Employee> EmployeeList = new List<Employee>();
    
    
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    //
    public Company(string Name)
    {
        this.Name = Name;
        // this.CreatedOn = CreatedOn;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company GoodCompany = new Company("The Best Place to Work");

        // Create three employees
        Employee Jason = new Employee();
        {
            Jason.FirstName = "Jason";
            Jason.LastName = "MelBourne";
            Jason.Title = "Big Guy";
            // Jason.StartDate = new DateTime();
        }
        Employee Maci = new Employee();
        {
            Maci.FirstName = "Maci";
            Maci.LastName = "Jack";
            Maci.Title = "CEO";
            // Maci.StartDate = new DateTime();
        }
        Employee Kyle = new Employee();
        {
            Kyle.FirstName = "Kyle";
            Kyle.LastName = "Anstess";
            Kyle.Title = "CFO";
            // Kyle.StartDate = new DateTime();
        }
        Employee Hannah = new Employee();
        {
            Hannah.FirstName = "Hannah";
            Hannah.LastName = "Morrish";
            Hannah.Title = "Sales Person";
            // Hannah.StartDate = new DateTime();
        }

        // Assign the employees to the company
        Company.EmployeeList.Add(Jason);
        Company.EmployeeList.Add(Maci);
        Company.EmployeeList.Add(Kyle);
        Company.EmployeeList.Add(Hannah);


        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        Console.WriteLine(GoodCompany);
        foreach(Employee employee in Company.EmployeeList)
        {
            Console.WriteLine($"{employee.FullName}");
        }
    }
}