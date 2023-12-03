// (1 primer ejercio programa que calcula la media de 3 notas 
// y indica si ha aprobado o suspendido)


// internal class Program
// {
//     private static void Main(string[] args)
//     { 
//         double nota1, nota2, nota3, suma;

//         Console.WriteLine("Ingresa la primera nota:");
//             nota1 = double.Parse(Console.ReadLine());

//             Console.WriteLine("Ingresa la segunda nota:");
//             nota2 = double.Parse(Console.ReadLine());

//             Console.WriteLine("Ingresa la tercera nota:");
//             nota3 = double.Parse(Console.ReadLine());



//         suma = nota1 + nota2 + nota3;




//          double media = suma/3;

//          Console.WriteLine($"la media de las notas es: {media}");

//             if(media >= 5)
//             {
//                Console.WriteLine("aprobado");  
//             }
//             else
//             {
//               Console.WriteLine("suspendido");  
//             }





//     }
// }




// (2 segundo programa que pide números al usuario y finaliza la ejecución con el número 0.
//  Cuando acabe, muestra por consola cuantos fueron pares y cuantos impares.)




// internal class Program
// {
//   private static void Main(string[] args)
//   {
//     int numPares = 0;
//     int numImpares = 0;
//     int num;

//     Console.WriteLine("Introduce números (0 para terminar):");

//     do
//     {
//       num = Convert.ToInt32(Console.ReadLine());

//       if (num != 0)
//       {
//         if (num % 2 == 0)
//         {
//           numPares++;
//         }
//         else
//         {
//           numImpares++;
//         }
//       }
//     } while (num != 0);

//     Console.WriteLine("introduciste " + numPares + " números pares y " + numImpares + " números impares.");
//   }
// }





// (3 tercer ejercicio programa “Calculadora”, con las 4 operacions básicas, 
// sumar restar, multiplicar y dividir)




// internal class Program
// {
//   private static void Main(string[] args)
//   {
//     double num1, num2, resultado;
//     int operacion;
//     string continuar;

//     do
//     {
//       Console.Write("Introduce el primer número: ");
//       num1 = Convert.ToDouble(Console.ReadLine());

//       Console.Write("Introduce el segundo número: ");
//       num2 = Convert.ToDouble(Console.ReadLine());

//       Console.WriteLine("Elige la operación: 1-Suma, 2-Resta, 3-Multiplicación, 4-División");
//       operacion = Convert.ToInt32(Console.ReadLine());

//       switch (operacion)
//       {
//         case 1:
//           resultado = num1 + num2;
//           Console.WriteLine("El resultado de la suma es: " + resultado);
//           break;
//         case 2:
//           resultado = num1 - num2;
//           Console.WriteLine("El resultado de la resta es: " + resultado);
//           break;
//         case 3:
//           resultado = num1 * num2;
//           Console.WriteLine("El resultado de la multiplicación es: " + resultado);
//           break;
//         case 4:
//           if (num2 != 0)
//           {
//             resultado = num1 / num2;
//             Console.WriteLine("El resultado de la división es: " + resultado);
//           }
//           else
//           {
//             Console.WriteLine("Error: División por cero no está permitida.");
//           }
//           break;
//         default:
//           Console.WriteLine("Operación no válida.");
//           break;
//       }

//       Console.Write("¿Deseas realizar otra operación? (s/n): ");
//       continuar = Console.ReadLine();
//     }
//     while (continuar == "s" || continuar == "S");
//   }
// }





//(4 Programa que pide números al usuario 
// hasta que encuentra uno compatible con la letra "a" calculo letra DNI)




// internal class Program
// {
//     private static void Main()
//     {
//         int numero;

//         do
//         {
//             Console.Write("Introduce un número de DNI (sin la letra): ");
//             numero = Convert.ToInt32(Console.ReadLine());

//             if (numero % 23 == 3)
//             {
//                 Console.WriteLine("Tu DNI es: " + numero + "A");
//                 break;
//             }
//         }
//         while (true);
//     }
// }






// (5 quinto ejercicio un Programa que Imprime en pantalla 
// un triangulo de 15 asteriscos de altura x 15 de base.)


// class Program
// {
//     static void Main()
//     {
//         for (int i = 1; i <= 15; i++)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//     }
// }


// (6 sexto ejercicio un programa Imprime en pantalla un tablero de ajedrez 
// con B para las blancas y N para las negras de 8X8)



// internal class Program
// {
//     private static void Main()
//     {
//         for (int i = 0; i < 8; i++)
//         {
//             for (int j = 0; j < 8; j++)
//             {
//                 if ((i + j) % 2 == 0)
//                 {
//                     Console.Write("B");
//                 }
//                 else
//                 {
//                     Console.Write("N");
//                 }
//             }
//             Console.WriteLine();
//         }
//     }
// }
