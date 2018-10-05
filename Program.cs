using System;

namespace suma_de_multiplos_de_3_y_5_alara06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número entero: ");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("La respuesta es:");
                Console.WriteLine( suma(num));
            }
            else
                Console.WriteLine("Número inválido.");
        }

        static int suma(int n)
        {
            int respuesta = 0 ;
            for(int i=0; i<n+1; i++)
                if(i%3 == 0 || i%5==0)
                    respuesta += i;
            return respuesta;



        }
    }
}
