// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        double montoTotal=0;
        double recargo=0;
        double montoOriginal=0;
        
        Console.WriteLine ("ingrese el monto original de la factura ($ - COD)");

        montoOriginal= Convert.ToDouble(Console.ReadLine());

        Console.WriteLine ("ingrese los dias de restraso en el pago");
        double diasRetraso= Convert.ToInt32(Console.ReadLine());
        
        montoTotal=montoOriginal;
        
        if(diasRetraso>5){

            recargo=montoOriginal * 0.05;
            montoTotal=montoOriginal + recargo;
            
            Console.WriteLine ("Se ha aplicado un recargo del 5% ($" + recargo +") por mora.");
        
        }

        Console.WriteLine ("monto total definitivo a pagar: $" + montoTotal);
    }
}
