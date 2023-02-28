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

Employee user1 = new Employee("Stefan", "Baranowski", "26", "71");
Employee user2 = new Employee("Mieciu", "Kotowski", "32", "68");
Employee user3 = new Employee("Kot", "Człowiekowski", "54", "72");

user1.Addscore(8);
user1.Addscore(1);
user1.Addscore(10);
user1.Addscore(7);
user1.Addscore(4);

user2.Addscore(8);
user2.Addscore(9);
user2.Addscore(5);
user2.Addscore(10);
user2.Addscore(2);

user3.Addscore(0);
user3.Addscore(9);
user3.Addscore(7);
user3.Addscore(5);
user3.Addscore(3);

var result = user1.Result;
Console.WriteLine(result);

var result2 = user2.Result;
Console.WriteLine(result2);

var result3 = user3.Result;
Console.WriteLine(result3);
class Employee
{
    private List<int> score = new List<int>();

    public Employee(string name, string score, string lastname, string age)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.Age = age;
        this.Score = score;
    }
    public string Name { get; private set; }


    public string Password { get; private set; }

    public string Lastname { get; private set; }

    public string Age { get; private set; }

    public string Score { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }

    }

    public void Addscore(int number)
    {
        this.score.Add(number);
    }
}