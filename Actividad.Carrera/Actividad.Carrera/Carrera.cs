using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Carrera
{
    class Carrera
    {
        Corredor c1;
        Corredor c2;
        private string _ganador;

        public Carrera(Corredor a, Corredor b)
        {
            c1 = a;
            c2 = b;
        }

        public string realizar()
        {
            string cadena = "";

            while (c1.noPasos < 100 && c2.noPasos < 100)
            {
                c1.avanzar();
                cadena += c1.ToString() + Environment.NewLine;
                c2.avanzar();
                cadena += c2.ToString() + Environment.NewLine + Environment.NewLine;

                if (c1.noPasos >= 100) _ganador = c1.nombre;
                if (c2.noPasos >= 100) _ganador = c2.nombre;
                if (c1.noPasos >= 100 && c2.noPasos >= 100) _ganador = "Empate";
            };

            return cadena;
        }

        public string ganador
        {
            get { return _ganador; }
        }
    }
}
