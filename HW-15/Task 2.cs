using System;
using System.Reflection;

class MyClass
{
    public int MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass { MyProperty1 = 42, MyProperty2 = "Hello, Reflection!" };

        Type myObjectType = typeof(MyClass);
        PropertyInfo[] properties = myObjectType.GetProperties();

        Console.WriteLine("Свойства класса MyClass и их значения:");
        foreach (var property in properties)
        {
            object value = property.GetValue(myObject);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
}
