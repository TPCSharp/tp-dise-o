using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Diseño
{
    class Ponderacion
    {
        private int valor;

        public Ponderacion(int ponderacion)
        {
            setValor(ponderacion);
        }

        public void setValor(int pond) { valor = pond; }

        public int getValor() { return valor; }
    }
}
