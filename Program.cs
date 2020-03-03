using System;
//Desarrollado por: Edison Xavier Safla Aranha
namespace series
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = false;
            int s = 0;

            do
            {
                Console.WriteLine("Serie de fibonacci!");
                Console.ReadKey();

                Console.WriteLine("Cuantos numero desea imprimir");
                s = Convert.ToInt32( Console.ReadLine());

                long a = 0;
                long b = 1;
                long aux = 0;


                for (int i = 0; i < s; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("{0}", a);
                    }
                    else
                    {
                        aux = a;
                        a = b;
                        b = aux + a;
                        Console.Write(", {0}", a);
                    }
                }
                Console.ReadKey();




                n = true;
            } while (n != true);



        }
    }
}
