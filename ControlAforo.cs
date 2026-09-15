// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int exceso=0;
        
        Console.WriteLine ("ingrese la cantidad de asistentes confirmados: ");

        int asistentes= Convert.ToInt32(Console.ReadLine());

        if(asistentes>150){

            exceso=asistentes -150;
            Console.WriteLine ("¡ALERTA! se ha excedido el limite de asistentes");
            Console.WriteLine ("Hay " + exceso + " Persona(s) por encima del limite permitido");
        }else{
            
            Console.WriteLine ("Todo esta en orden");
        }

        Console.WriteLine ("Programa finalizado finalizado.");
    }
}
