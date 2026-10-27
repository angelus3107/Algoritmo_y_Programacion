using System;

public class HelloWorld {
    public static void Main(string[] args) {
        int altura = 5;

        
        for (int i = 0; i < altura; i++) {

            
            for (int j = 0; j < altura - i - 1; j++) {
                Console.Write(" ");
            }

            
            for (int k = 0; k < (2 * i + 1); k++) {
                
                Console.Write("*");
            }

            
            Console.WriteLine();
        }
    }
}
