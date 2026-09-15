// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        
        Console.WriteLine ("ingrese un numero");

        double n= Convert.ToDouble(Console.ReadLine());

        if(n>=0){
            Console.WriteLine ("El numero es positivo");
        }else{
            Console.WriteLine ("El numero es negativo");
        }

        Console.WriteLine ("Programa finalizado.");
    }
}
