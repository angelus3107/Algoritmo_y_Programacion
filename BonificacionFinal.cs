// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        double sueldoBase=2200000;
        double bonificacion=200000;
        double sueldoFinal=sueldoBase;
        
        Console.WriteLine ("ingrese la cantidad de unidades vendidas en el mes");

        int unidadesVendidas= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("ingrese los años de antiguedad en la empresa");
        int antiguedad= Convert.ToInt32(Console.ReadLine());
        
        
        if(unidadesVendidas>50 && antiguedad>2){

            sueldoFinal= sueldoBase+bonificacion;
            
            Console.WriteLine ("¡Felicidades! Ha cumplido con las metas de ventas! tienes una bonificacion de: " + bonificacion);
            
        
        }

        Console.WriteLine ("Sueldo final: $" + sueldoFinal);
    }
}
