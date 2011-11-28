using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //necesario para declarar los arreglos

namespace TP_Diseño
{

    class Competencia
    {
        private int codigo;
        private string nombre;
        private string descripcion;
        private ArrayList listaFactores;

        public Competencia(int cod, string nom, string des)
        {
            codigo = cod; // solo se inicializa aqui este codigo.
            setNombre(nom);
            setDescripcion(des);
            listaFactores = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string des) { descripcion = des; }
        public void addFactor(Factor fact) { listaFactores.Add(fact); }

        public int getCodigo() { return codigo; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public ArrayList getFactores() { return listaFactores; }

    }
}
