using System;

namespace LAB_SEMANA_12_EJEMPLO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            int numero1, numero2; 

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  Hola Mundo ");
            Console.WriteLine("Presione 2: ------>  Una Suma");
            Console.WriteLine("Presione 3: ------>  Salir"); 

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("HOLA MUNDO"); 
                        break;

                case "2":
                    Console.WriteLine("Ingrese un número");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro número");
                    numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("La suma es : " + (numero1 + numero2)); 
                    break;
                case "3":
                    Console.WriteLine("Chao");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Aqui no es "); 
                    break; 

            }
            
        }
    }
}
