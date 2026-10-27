using System;

public class Program {
    public static void Main(string[] args) {
        bool continuar = true;

        while (continuar) {
          
            Console.WriteLine("\n--- MENÚ DE FIGURAS ---");
            Console.WriteLine("1. Mostrar Cuadrado Hueco");
            Console.WriteLine("2. Mostrar Pirámide Centrada");
            Console.WriteLine("3. Mostrar Triángulo Invertido");
            Console.WriteLine("4. Mostrar Rombo");
            Console.WriteLine("5. Salir");
            Console.Write("Selecciona una opción (1-5): ");
            
            string opcion = Console.ReadLine();
            
            Console.WriteLine();

            switch (opcion) {
                    
                case "1":
                    
                    Console.WriteLine("*****");
                    
                    for (int i = 0; i < 3; i++) {
                        
                        for (int j = 0; j < 1; j++) {
                            
                            Console.WriteLine("*   *");
                        }
                    }
                    Console.WriteLine("*****");
                    
                    break;

                case "2":
                    
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
                    break;

                case "3":
                    
                    int cantidad = 5;
                    
                    char forma = '*'; 
                    
                    for (int i = 0; i < 5; i++) {
                        
                        Console.WriteLine(new string(forma, cantidad));
                        
                        cantidad = cantidad - 1;
                    }
                    break;

                case "4":
                    
                    int n = 5;
                    
                    for (int i = 0; i < n; i++) {
                        
                        for (int j = 0; j < n - i - 1; j++) {
                            
                            Console.Write(" ");
                        }
                        
                        for (int k = 0; k < (2 * i + 1); k++) {
                            
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    for (int i = n - 2; i >= 0; i--) {
                        
                        for (int j = 0; j < n - i - 1; j++) {
                            
                            Console.Write(" ");
                        }
                        for (int k = 0; k < (2 * i + 1); k++) {
                            
                            Console.Write("*");
                            
                        }
                        Console.WriteLine();
                    }
                    break;

                case "5":
                    
                    Console.WriteLine("¡Gracias por usar el programa!");
                    
                    continuar = false;
                    
                    break;

                default:
                    
                    Console.WriteLine("Opción no válida. Por favor, digita un número del 1 al 5.");
                    
                    break;
            }
        }
    }
}
