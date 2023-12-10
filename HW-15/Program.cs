using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type consoleType = typeof(Console);

        MethodInfo[] methods = consoleType.GetMethods();

        Console.WriteLine("Методы класса Console:");
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
