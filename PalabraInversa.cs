using System;
// Desarrollado por : Edison Xavier Safla Aranha
namespace Inversa
{

    class PalabraInversa
    {
        static void Main(string[] args)
        {


            String volver;
            
            string palabra1;
           
                do
                {
                    Console.WriteLine("Ingrese una palabra");
                    palabra1 = Console.ReadLine();

                    char[] palabra = palabra1.ToCharArray();
                

                    Array.Reverse(palabra);
                 

                    Console.WriteLine("Su palabra es:" + palabra1);
                     Console.WriteLine("La palabra invertida es: ");
               
                for (int i = 0; i < palabra.Length; i++) 
                { 
                    Console.Write(palabra[i]);
                }
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Volver a intentar? y/n");
                    volver = Console.ReadLine();

                }
                while (volver != "n");
            {
                Console.WriteLine("Adios !");
                Console.ReadKey();
            }


            
        }
    }
}
