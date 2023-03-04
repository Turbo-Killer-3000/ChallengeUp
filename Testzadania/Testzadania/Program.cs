using System;

class Employee
{
    // fields
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int[] Ratings { get; set; } = new int[5];

    // constructor
    public Employee(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // method to calculate total ratings
    public int CalculateTotalRatings()
    {
        int total = 0;
        foreach (int rating in Ratings)
        {
            total += rating;
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        // create three employees
        Employee employee1 = new Employee("John", "Doe", 30);
        employee1.Ratings = new int[] { 4, 5, 3, 2, 4 };

        Employee employee2 = new Employee("Jane", "Smith", 25);
        employee2.Ratings = new int[] { 3, 4, 5, 9, 3 };

        Employee employee3 = new Employee("Bob", "Johnson", 40);
        employee3.Ratings = new int[] { 5, 4, 3, 5, 5 };

        // determine employee with highest total ratings
        Employee[] employees = { employee1, employee2, employee3 };
        Employee highestRatedEmployee = null;
        int highestTotalRatings = 0;

        foreach (Employee employee in employees)
        {
            int totalRatings = employee.CalculateTotalRatings();
            if (totalRatings > highestTotalRatings)
            {
                highestRatedEmployee = employee;
                highestTotalRatings = totalRatings;
            }
        }

        // print out details of highest-rated employee
        Console.WriteLine("The highest-rated employee is:");
        Console.WriteLine("Name: {0} {1}", highestRatedEmployee.FirstName, highestRatedEmployee.LastName);
        Console.WriteLine("Age: {0}", highestRatedEmployee.Age);
        Console.WriteLine("Total Ratings: {0}", highestTotalRatings);
    }
}

