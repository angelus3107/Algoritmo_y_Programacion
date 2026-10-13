// Solicita al usuario  que ingrese una contraseña. usando un do-while
// Sigue pidiendo la contraseña hasta que coincida con una predefinida ().
//Al finalizar, muestra cuantos intentos fallidos realizo antes de acertar.


using System;

public class HelloWorld {
    public static void Main(string[] args) {

        const String passCorrecta = "system552";
        String clave;
        int intentosF = 0;

    
        do{

            Console.WriteLine ("ingrese la contraseña");
            clave = Console.ReadLine();

            if(clave!=passCorrecta){
                intentosF++;
                Console.WriteLine ("contraseña incorrecta intentalo de nuevo");
                
            }
            
        }while(clave != passCorrecta);

        Console.WriteLine ($"\n Acceso concedido.");
        Console.WriteLine ($"\n intentos fallidos: {intentosF}.");
        

        
    }
}
