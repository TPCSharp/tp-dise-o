using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Diseño
{
    class OpcionesEvaluadas
    {
        private string nombre;
        private int valor;

        public OpcionesEvaluadas(string nom, int valor)
        {
            setNombre(nom);
            setPonderacion(valor);
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setPonderacion(int pond) { valor = pond; }

        public string getNombre() { return nombre; }
        public int getPoderacion() { return valor; }
    }
}
