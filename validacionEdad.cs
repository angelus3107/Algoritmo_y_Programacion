// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("por favor, ingrese su edad");

        int edad= Convert.ToInt32(Console.ReadLine());

        if(edad>=18){
            Console.WriteLine("eres mayor de edad");
        }

        else{Console.WriteLine("eres menor de edad");
         }

        Console.WriteLine("gracias por usar el programa");
    }
}
