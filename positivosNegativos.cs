// Online C# compiler (editor) for free
// Write and run C# online using this editor.

using System;

public class HelloWorld {
    public static void Main(string[] args) {

        int[] num = new int [5];

        int positivo=0;
        int negativo=0;
        
        Console.WriteLine ("igrese 5 numeros");
        
        for(int i=1; i<6; i++){
            Console.WriteLine("ingrese el numero " + i);

            num[i-1]=Convert.ToInt32(Console.ReadLine());
        }

        for(int i=1;i<6; i++){
            if(num[i-1]<0){
                negativo++;
            }else{positivo++;}
        }
        Console.WriteLine("numeros positivos: " + positivo);
        Console.WriteLine("numeros negativos: " + negativo);
    }
}
