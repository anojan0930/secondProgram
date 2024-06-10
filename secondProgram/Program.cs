using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        printHello();
        GreetUser("Anojan");
    }
    static void printHello()
    {
        Console.WriteLine("hello,world");

    }
    static void GreetUser(string name)
    {
        Console.WriteLine("hello "+name);
    }
    
}