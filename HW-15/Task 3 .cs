using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        string myString = "This is a sample string";

        Type stringType = typeof(string);
        MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

        if (substringMethod != null)
        {
            object[] parameters = { 5, 7 }; // начальный индекс и длина подстроки
            object result = substringMethod.Invoke(myString, parameters);

            Console.WriteLine("Подстрока: " + result);
        }
    }
}
