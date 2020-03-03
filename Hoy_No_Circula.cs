using System;
//Desarrollado por : Edison Xavier Safla Aranha
namespace Hoy_NO_circula
{
    class Hoy_No_Circula
    {


        public static void Main(string[] args)
        {

            string placa;
            string opcion;
            char[] arr;
           

            do
            {
                Console.WriteLine("Ingrese su placa.");
                placa = Console.ReadLine();

                arr = placa.ToCharArray(6, 1);
                
                string str = new String(arr);
                int digito = Convert.ToInt32(str);
            

                Validaciones(digito);
                Console.WriteLine("Desea continuar ? y/n ");
                opcion =Console.ReadLine();

               
            }
            while (opcion != "n" );

            {
                Console.WriteLine("Adios !");
                Console.ReadKey();
                
            }

          
        }
         
        public static void Validaciones(int digito)
        {


            if (digito == 1 || digito == 2)
            {
                Console.WriteLine("No salir los lunes!!!");
                Console.ReadKey();

            }
            else if (digito == 3 || digito == 4)
            {
                Console.WriteLine("No salir los martes !!!");
            }
            else if (digito == 5 || digito == 6)
            {
                Console.WriteLine("No salir los miercoles !!!");
            }
            else if (digito == 7 || digito == 8)
            {
                Console.WriteLine("No salir los jueves !!!");
            }
            else if (digito == 9 || digito == 0)
            {
                Console.WriteLine("No salir los viernes !!!");
            }
            else
            {
                Console.WriteLine("No es valido el digito");
            }
        }

    }
}
