using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.LiebreYTortuga
{
    class Tortuga : Competidores
    {
        public Tortuga()
        {
            _noPasos = 0;
        }

        public override void avanzar()
        {
            int n = num.Next(1, 11);

            if (n < 6) _noPasos += 3;
            else if (n < 8) _noPasos -= 6;
            else
                _noPasos += 1;
            if (_noPasos < 0) _noPasos = 0;
        }

        public override string ToString()
        {
            return "La tortuga esta en " + this.noPasos;
        }
    }
}
