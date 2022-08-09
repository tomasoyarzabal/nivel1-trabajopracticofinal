using System;

namespace TPFinal_Oyarzabal
{
    class Program
    {
        static void Main(string[] args)
        {
          ////Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
          //// a. El mayor de los números pares.
          //// b. La cantidad de números impares.
          //// c. El menor de los números primos.
          //// Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

          int Numero;
          bool BanderaPar = false;
          int MaxPar = 0;
          int ContadordeImpares = 0;
          bool BamderaPrimo = false;
          int MenorPrimo = 0;
          Console.WriteLine("ingrese un numero");
          Numero = int.Parse(Console.ReadLine());
          while (Numero != 0)
          {
            if(Numero % 2 == 0)
            {
             if(BanderaPar == false)
             {
                MaxPar = Numero;
                BanderaPar = true;
             }
             else
             {
                MaxPar = Numero;
             }

            }
            else
            {
                ContadordeImpares++;
            }
            if(primo(Numero))
            {
                if(BamderaPrimo == false)
                {
                    MenorPrimo = Numero;
                    BamderaPrimo = true;
                }
                else if(Numero < MenorPrimo)
                {
                    MenorPrimo = Numero;
                }
            }
            Console.WriteLine("ingrese un numero");
            Numero = int.Parse(Console.ReadLine());
          }  

          Console.WriteLine("El maximo numero par es: " + MaxPar);
          Console.WriteLine("La cantidad de numeros impares es: " + ContadordeImpares);
          Console.WriteLine("El menor numero primo es: " + MenorPrimo);
        }

        static bool primo(int a)
        {
           int con = 0;
           for (int x = 1; x <= a; x++)
           {
            if(a % x == 0)
              con++;
           }
           if(con == 2)
           {
             return true;
           }
           else
           {
            return false;
           }
        }
    }
}
