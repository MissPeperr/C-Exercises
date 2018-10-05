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
    public DateTime StartDate { get; set; }
    public int CompanyId { get; set; }
    
    public void ListEmployees(Employee employee)
    {
        Console.WriteLine(FullName);
    }
}
public class Company
{
        public Company(string Name, DateTime CreatedOn, int Id)
    {
        this.Name = Name;
        this.CreatedOn = CreatedOn;
        this.Id = Id;
    }

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    public int Id { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> EmployeeList = new List<Employee>();
    
    
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    //

}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        /*
            This is using the Company Constructor to create a new Company with the properties: Name, CreatedOn
        */
        Company GoodCompany = new Company("The Best Place to Work", DateTime.Now, 1);
        Company BadCompany = new Company("The WORST Place to Work", DateTime.Now, 2);

        // Create three employees
        Employee Jason = new Employee();
        {
            Jason.FirstName = "Jason";
            Jason.LastName = "MelBourne";
            Jason.Title = "Big Guy";
            Jason.StartDate = new DateTime(2018, 5, 23);
            Jason.CompanyId = GoodCompany.Id;
        }
        Employee Maci = new Employee();
        {
            Maci.FirstName = "Maci";
            Maci.LastName = "Jack";
            Maci.Title = "CEO";
            Maci.StartDate = DateTime.Now;
            Maci.CompanyId = GoodCompany.Id;

        }
        Employee Kyle = new Employee();
        {
            Kyle.FirstName = "Kyle";
            Kyle.LastName = "Anstess";
            Kyle.Title = "CFO";
            Kyle.StartDate = new DateTime(2018, 2, 13);
            Kyle.CompanyId = BadCompany.Id;
        }
        Employee Hannah = new Employee();
        {
            Hannah.FirstName = "Hannah";
            Hannah.LastName = "Morrish";
            Hannah.Title = "Sales Person";
            Hannah.StartDate = new DateTime();
            Hannah.CompanyId = BadCompany.Id;
        }

        // Assign the employees to the company
        GoodCompany.EmployeeList.Add(Jason);
        GoodCompany.EmployeeList.Add(Maci);
        BadCompany.EmployeeList.Add(Kyle);
        BadCompany.EmployeeList.Add(Hannah);


        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        foreach(Employee employee in GoodCompany.EmployeeList)
        {
            Console.WriteLine($"{employee.FullName} started on {employee.StartDate}, at {GoodCompany.Name}");
        }
        foreach(Employee employee in BadCompany.EmployeeList)
        {
            Console.WriteLine($"{employee.FullName} started on {employee.StartDate}, at {BadCompany.Name}");
        }
    }
}