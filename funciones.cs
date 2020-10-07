using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quinto_ejercicio
{
    public static class Validaciones
    {

        public static string ValidarCadena(string mensaje)
        {
            string datoParaValidar = Console.ReadLine();

            while (string.IsNullOrEmpty(datoParaValidar) || string.IsNullOrWhiteSpace(datoParaValidar))
            {
                Console.WriteLine($"error,{mensaje} dato no correcto, por favor reingrese");
                datoParaValidar = Console.ReadLine();
            }

            return datoParaValidar;
        }


        public static int ValidadEntero(int numMax, int numMin)
        {
            int aux;

            while (!int.TryParse(Console.ReadLine(), out aux) || aux > numMax || aux < numMin)
            {
                Console.WriteLine(" Error,no es un dato valido, por favor reingrese");
            }

            return aux;
        }

        public static int ValidadVacaciones(int num)
        {
            int aux;
            if( num < 6){
                return 10;
            } else {
                aux = (num - 5) + 10;
                return aux;
            }
        }

        public static int ValidadEntero()
        {
            int aux;

            while (!int.TryParse(Console.ReadLine(), out aux) )
            {
                Console.WriteLine("Error,no es un dato valido, por favor reingrese");
            }

            return aux;
        }

    }
}