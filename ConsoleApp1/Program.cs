// See https://aka.ms/new-console-template for more information



/*
using ListOfInt = int;

var print = (string message = "") => Console.WriteLine(message);

ListOfInt o = 123;

Console.WriteLine($$"""{ "TimeStamp": "{{DateTime.Now}}" }""");



Person p = new Person("Alice", "Jones");

print("name" + p.FirstName);
p.Print();
ReadOnlySpan<byte> utf8 = "ab→cd"u8; // Arrow symbol consumes 3 bytes
Console.WriteLine(utf8.Length); // 7
foreach(var c in utf8)
{
    Console.WriteLine(c);
}


using System.Runtime.CompilerServices;

var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
var a2 = a1 with { E = 10 };
Console.WriteLine(a2); // { A = 1, B = 2, C = 3, D = 4, E = 10 }
Console.WriteLine(a1); // { A = 1, B = 2, C = 3, D = 4, E = 5 }


var point = (3, 4);
double x = 0;
(x, double y) = point;
Console.WriteLine(x);
Console.WriteLine(y);

class Person(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public void Print() => Console.WriteLine(firstName + " " + lastName);
}

*/

using System.Runtime.CompilerServices;

Print(Math.PI * 2);
void Print(double number, [CallerArgumentExpression("number")] string expr = null)  => 
    Console.WriteLine(expr);
// Output: Math.PI * 



var p2 = new Point(2, 34);
Point p1 = new(0, 10);

//var p3 = new Punto(2, 34);
//Punto p4 = new(0, 10);




Console.WriteLine("point1 "+p1);

Console.WriteLine("point2 " + p2);


Logger logger = new Logger();

//logger.Log("aouaoue");


var logger1 = (ILogger) new Logger();

logger1.Log("aouaoue");

((ILogger)new Logger()).Log("12313123");


int cardNumber = 8;

string cardName = cardNumber switch // assuming cardNumber is an int
{
    13 => "King",
    12 => "Queen",
    11 => "Jack",
    _ => "Pip card" + cardNumber// equivalent to 'default'
};


logger1.Log("card name "+cardName);

record Point
{
    public Point(double x, double y) => (X, Y) = (x, y);
    public double X { get; init; }
    public double Y { get; init; }
}


public struct Punto { public int X; public int Y; }

interface ILogger
{
    void Log(string text) => Console.WriteLine(text);
}

public class Logger:ILogger
{
  // public void Log(string text) => Console.WriteLine("some other "+text);
}