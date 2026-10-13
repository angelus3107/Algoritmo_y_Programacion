// pide numeros enteros y acumula  su suma hasta que ingrese 0. muestra la suma de total. cuantos numeros se ingresaron y el promedio 


using System;

public class HelloWorld {
    public static void Main(string[] args) {

        int num;
        int suma=0;
        int contador=0;
        

        do{
            Console.WriteLine ("ingrese el numero");
            num=Convert.ToInt32(Console.ReadLine());

            if(num !=0){
                suma+= num;
                contador++;
            }
        }while(num != 0);

        
        Console.WriteLine ($"suma total: {suma}");
        Console.WriteLine ($"se ingresaron: {contador} numeros");
        
        if(contador>0){
            Console.WriteLine ($"el promedio fue: {(double)suma/contador:F2}");
        }else 
        {Console.WriteLine ($"no se ingresaron numeros");}
    }
}
