// var cyfra1 = 5;
// var cyfra1 = 5;
// var cyfra2 = 10;

// Operatory relacijne
// == równa się 
// != różne 
// < większe
// > mniejsze
// < większe lub równe 
// > mniejsze lub równe

// Operatory logiczne
// && I
// || Lub
// ! Czy 

// Ważne podpowiedzi 
// else if
// Upożądkowyanie kodu ctrl + k + d
// Var uniwersalna zmienna

// var name = "Mateusz";
// var age = 19;

// if (name == "Mateusz" && age < 18) 
// {
// Console.WriteLine("Dobra robota!! ");
// }
// else
// {
// Console.WriteLine("TAK");
// }

//var name1 = ("Ewa");
//var gender1 = ("Kobieta");
//var gender2 = ("Męzczyzna") ;
//var age1Ewa = 33 ;
//var age2M = 17 ;
//var age3Kobieta = 20 ;

//if (name1 == "Ewa" && age1Ewa == 33) 
//{
//    Console.WriteLine("Ewa lat 33") ; 
//}
//else 
//{
//    Console.WriteLine("Istota o wieku niezbadanym");
//}

//if (gender2 == "Męzczyzna" && age2M < 18) 
//{
//    Console.WriteLine("Niepełnoletni męzczyzna");
//}
//else 
//{
//    Console.WriteLine("Męzczyzna po 18");
//}

//if (gender1 == "Kobieta" && age3Kobieta < 30)
//{
//    Console.WriteLine("Kobieta poniżej 30") ;
//}
//else
//{
//    Console.WriteLine("Kobieta po 30");
//}

//var Employee = "Marcin";
//var Employee2 = "Stefan";
//var Employee3 = "Staszek";

//var name = "Marcin";
//var name2 = "Stefan";
//var name3 = "Staszek";

//var lastname = "Grabowski";
//var lastname2 = "Wasilewski";
//var lastname3 = "Stachurski";

//var age = 34;
//var age2 = 53;
//var age3 = -29;

//Console.WriteLine("dane twojego pracownika to  " +  name + lastname + age);   

using Chellenge_App;

Employee employee1 = new Employee("Stefan", "Baranowski", "26");
Employee employee2 = new Employee("Marcin", "Kotowski", "32" );
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

var result = employee1.Result;
//Console.WriteLine(result);

var result2 = employee2.Result;
//Console.WriteLine(result2);

var result3 = employee3.Result;
//Console.WriteLine(result3);

List<Employee> employees = new List<Employee>()
{
            employee1,employee2,employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var enployee in employees)
{
    if(employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
    }
    if(employee2.Result > employee1.Result)
    {
        employeeWithMaxResult = employee2;    
    }
    if(employee3.Result > employee2.Result)
    {
        employeeWithMaxResult = employee3;
    }
    else if(employee3.Result > employee1.Result)
    {
        employeeWithMaxResult = employee3;
    }
    //{
    //    employeeWithMaxResult = employee2;
    //}
    //if (employee3.Result > maxResult)
    //{
    //    employeeWithMaxResult = employee3;
    //}
}
Console.WriteLine("The best employee is :");

Console.WriteLine("His name is :" + employeeWithMaxResult.Name); 
Console.WriteLine("His last name is : " + employeeWithMaxResult.Lastname);
Console.WriteLine ("His score is :" + employeeWithMaxResult.Result);