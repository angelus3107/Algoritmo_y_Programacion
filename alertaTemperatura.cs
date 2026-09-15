// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        
        Console.WriteLine ("ingrese la temperatura actual en grados celsius");

        double temp= Convert.ToInt32(Console.ReadLine());

        if (temp<0){

            Console.WriteLine("ADVERTENCIA: Temperatura bajo cero detectada. ");
            Console.WriteLine("Riesgo de congelamiento en carreteras \n Conduzca con precaucion :)");
        }else {
            Console.WriteLine("No hay riesgo de congelamiento");
        }

        Console.WriteLine("Registro meteorologico completado.");

        
    }
}
