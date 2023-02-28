
int number = 5457;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;
var counter8 = 0;
var counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    { 
        counter1++;
    }
    if (letter == '2') 
    {
        counter2++;   
    }
    else if (letter == '3')
    {
        counter3++;
    }
    if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }


}
    
Console.WriteLine("0 is used => " + counter0);
Console.WriteLine("1 is used => " + counter1);
Console.WriteLine("2 is used => " + counter2);
Console.WriteLine("3 is used => " + counter3);
Console.WriteLine("4 is used => " + counter4);
Console.WriteLine("5 is used => " + counter5);
Console.WriteLine("6 is used => " + counter6);
Console.WriteLine("7 is used => " + counter7);
Console.WriteLine("8 is used => " + counter8);
Console.WriteLine("9 is used => " + counter9);