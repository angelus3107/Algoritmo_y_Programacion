using System;

public class HelloWorld {

    
    public static void Main(string[] args) {
        
        int cantidad = 5;
        
        char forma = '*'; 

        for(int i=0; i<5; i++){
            
        Console.WriteLine(new string(forma, cantidad));

            cantidad=cantidad-1;

        }
    }
}
