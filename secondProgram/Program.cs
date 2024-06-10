using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        printHello();
        GreetUser("Anojan");
        MultibleMethod("Anojan","Anoj");
    }
    static void printHello()
    {
        Console.WriteLine("hello,world");

    }
    static void GreetUser(string name)
    {
        Console.WriteLine("hello "+name);
    }
    static void MultibleMethod(string name , string name1)
    {
        Console.WriteLine(name +  \n  + name1);
    }
}