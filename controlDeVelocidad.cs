// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("por favor, ingrese la velocidad registrada del vehiculo (km/h)");

        int velocidad= Convert.ToInt32(Console.ReadLine());

        if (velocidad>=80){
            
            Console.WriteLine("¡¡ALERTRA!! ha superado el limite de velocidad de 80 km/h");
            Console.WriteLine("se ha generado una fotomulta automaticamente");
        }else {
            
            Console.WriteLine("velocidad dentro del limite permitido");
        }

        Console.WriteLine("Evaluacion de transito finalizada");

    }
}
