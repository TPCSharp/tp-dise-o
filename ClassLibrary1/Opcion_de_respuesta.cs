using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //necesario para declarar los arreglos

namespace TP_Diseño
{
    class OpciondeRespuesta // Una opcion de respuesta seria "Bueno, Muy bueno, Excelente"
    {
        private string nombre;
        private string descripcion;
        private ArrayList listaOpciones; // (lista de opciones) ej de opcion: "Excelente = 10" Excelente es el 'nombre' y 10 el 'valor'

        public OpciondeRespuesta(string nom, string des)
        {
            setNombre(nom);
            setDescripcion(des);
            listaOpciones = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string des) { descripcion = des; }
        public void addOpcion(Opciones opcion) { listaOpciones.Add(opcion); }

        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public ArrayList getOpciones() { return listaOpciones; }
    }
}
