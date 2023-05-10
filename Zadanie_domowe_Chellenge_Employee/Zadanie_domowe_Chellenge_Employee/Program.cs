using Chellenge_App;

Employee employee1 = new Employee("Stefan", "Baranowski", "26");
Employee employee2 = new Employee("Marcin", "Kotowski", "32");
Employee employee3 = new Employee("Kot", "Człowiekowski", "54");

employee1.Addscore(8);
employee1.Addscore(1);
employee1.Addscore(10);
employee1.Addscore(7);
employee1.Addscore(4);

employee2.Addscore(8);
employee2.Addscore(9);
employee2.Addscore(5);
employee2.Addscore(10);
employee2.Addscore(2);

employee3.Addscore(0);
employee3.Addscore(9);
employee3.Addscore(7);
employee3.Addscore(5);
employee3.Addscore(3);

//var result = employee1.Result;
//Console.WriteLine(result);

//var result2 = employee2.Result;
//Console.WriteLine(result2);

//var result3 = employee3.Result;
//Console.WriteLine(result3);

List<Employee> employees = new List<Employee>()
{
            employee1,employee2,employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var enployee in employees)
{
    if (employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
    }
    if (employee2.Result > employee1.Result)
    {
        employeeWithMaxResult = employee2;
    }
    if (employee3.Result > employee2.Result)
    {
        employeeWithMaxResult = employee3;
    }
    else if (employee3.Result > employee1.Result)
    {
        employeeWithMaxResult = employee3;
    }
}
Console.WriteLine("The best employee is :");

Console.WriteLine("His name is :" + employeeWithMaxResult.Name);
Console.WriteLine("His last name is : " + employeeWithMaxResult.Lastname);
Console.WriteLine("His age is : " + employeeWithMaxResult.Age);
Console.WriteLine("His score is :" + employeeWithMaxResult.Result);