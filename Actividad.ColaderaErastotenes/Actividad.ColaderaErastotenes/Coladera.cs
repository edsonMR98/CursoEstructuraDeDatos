using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ColaderaErastotenes
{
    class Coladera
    {
        private int[] elementos = new int[1000];

        public string eratostenes()
        {
            string cadena = "";

            for (int x = 1; x < 1000; x++) elementos[x] = 1; // inicializamos los elementos del vector en 1
            
            for (int x = 2; x < 1000; x++)
            {
                int div = 1;                    // variable utlizada para determinar si el numero x, solo tiene dos divisores
                for (int y = 2; y <= x; y++)    // ciclo para recorrer los numeros del 2 hasta x
                {
                    if ((x % y) == 0) div++;    // validamos si x modulo y es 0, es decir que es divisible, un numero primo
                }                               // solo es divisble por dos numeros, asi que div debe ser 2, para que x sea primo
                if (div == 2) for (int z = x + x; z < 1000; z += x) elementos[z] = 0;   // si div es 2, el numero es primo y se aplica
            }                                                                           // el metodo erastotenes, y se pone un 0 a los multiplos de x


            for (int x = 2; x < 1000; x++)
            {
                if (elementos[x] == 1) cadena += x + " , ";
            }

            return cadena;
        }
    }
}
