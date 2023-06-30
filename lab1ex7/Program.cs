using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program care va verifica daca un numar citit de la tastatura este par sau impar. In cazul in care numarul este par, programul va afisa “Numar par” iar in caz contrar, “Numar impar” */

            int n1;
            
            Console.WriteLine("Introduceti numarul:" + "\n");
            n1 = int.Parse(Console.ReadLine());

        
            if (n1%2==0)
            {
                Console.WriteLine("\n" + "Numar par.");
            }


            else
            {
                Console.WriteLine("\n" + "Numar impar.");
            }


        }
    }
}