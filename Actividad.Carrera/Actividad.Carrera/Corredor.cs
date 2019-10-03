using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Carrera
{
    class Corredor
    {
        private string _nombre;
        private int _noPasos;
        Random num = new Random(Guid.NewGuid().GetHashCode());
        
        public Corredor(string nombre)
        {
            _nombre = nombre;
            _noPasos = 0;
        }

        public string nombre
        {
            get { return _nombre; }
        }

        public int noPasos
        {
            get { return _noPasos; }
        }

        public void avanzar()
        {
            int n = num.Next(1, 11);

            if (n < 6) _noPasos += 2;
            else if (n < 8) _noPasos += 3;
            else
                _noPasos += 1;
        }

        public override string ToString()
        {
            return "El corredor " + this.nombre + " esta en " + this.noPasos; 
        }
    }
}
