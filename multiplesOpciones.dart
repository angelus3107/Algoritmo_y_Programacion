import 'dart:io';

void main() {

  print("que quiere hacer? *. /, +, -");

  String? entrada = stdin.readLineSync();

  print("ingrtese el primer numero");
  String? nume1 = stdin.readLineSync();
  int num1 = int.parse(nume1!);
  
  print("ingrtese el segundo numero");
  String? nume2 = stdin.readLineSync();
  int num2 = int.parse(nume2!);

  switch(entrada){

    case "+":
      print("resultado: ${num1+num2}");
      break;

    case "-":
      print("resultado: ${num1 - num2}");
      break; 

    case "*":
      print("resultado : ${num1* num2}");
      break;

    case "/":
      print("resultado : ${num1 / num2}");
      break;
      
  }
  
}
