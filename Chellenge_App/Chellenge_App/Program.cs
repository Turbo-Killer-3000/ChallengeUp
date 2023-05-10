using Chellenge_App;
   
var employee = new Employee("Mateusz", "Badura");
employee.AddGrade("2");
employee.AddGrade("2");
employee.AddGrade(6);
var statistics = employee.GetStatistics();

