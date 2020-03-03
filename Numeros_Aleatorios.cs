using System;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números aleatorios!");
            string salir;
            int numero;
            int aleatorio;
            do
            {
                Console.WriteLine("Cuantos numero aleatorios desea: ");
                numero= Convert.ToInt32( Console.ReadLine());

                for (int i=0;i<numero; i++)
                {

                   
                    var random = new Random();
                    aleatorio = random.Next(6);

                    Console.Write(aleatorio);
                    
                }
                Console.WriteLine("");

                Console.WriteLine("Desea salir ? y/n");
                salir = Console.ReadLine();
            } while (salir != "y");

        }
    }
}
