using Chellenge_App;

var employee1 = new Employee("Mateusz", "Badura");

employee1.AddGrade(2);
employee1.AddGrade(9);
employee1.AddGrade(6);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Max : {statistics.Max}");
