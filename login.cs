// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public class HelloWorld {
    public static void Main(string[] args) {

        /*cre un programa que simule un sistema de inicio de sesion 
        el usuario debe ingresar un correo de dominio unicaribe.edu.co y su contraseña
        
        debe permitir maximo 3 intentos*/

        string user="miguelamador@unicaribe.edu.co";
        string password="m557";

        int intentos=3;

        while(intentos!=0){

            Console.WriteLine("ingrese su usuario");
            string inputUsr= Console.ReadLine();
            
            Console.WriteLine("ingrese su contraseña");
            string inputPas= Console.ReadLine();

            if(inputUsr==user && inputPas==password){
                Console.WriteLine("Sesion iniciada bienvenido a la plataforma de UNICARIBE");
            }else{
                intentos--;
                Console.WriteLine("Contraseña o usuario incorrecto te quedan " + intentos + " intentos");   
            }

            if(intentos==0){
                Console.WriteLine("Llegaste al limite de intentos. Usuario Bloqueado - Comunicate con T.I - UNICARIBE");
            }
        }

        
        
    }
}
