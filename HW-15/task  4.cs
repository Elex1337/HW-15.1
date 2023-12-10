using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type listType = typeof(List<>);
        Type genericArgumentType = typeof(int); // или любой другой тип

        Type constructedListType = listType.MakeGenericType(genericArgumentType);

        ConstructorInfo[] constructors = constructedListType.GetConstructors();

        Console.WriteLine("Конструкторы класса List<int>:");
        foreach (var constructor in constructors)
        {
            Console.WriteLine(constructor);
        }
    }
}
