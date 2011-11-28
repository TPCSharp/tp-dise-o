using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    class OpciondeRespuestaEvaluada // Una opcion de respuesta seria "Bueno, Muy bueno, Excelente"
    {
        private string nombre;
        private string descripcion;
        private ArrayList listaOpcionesEv; // (lista de opcion) ej de opcion: "Excelente = 10" Excelente es el 'nombre' y 10 el 'valor'

        public OpciondeRespuestaEvaluada(string nom, string des)
        {
            setNombre(nom);
            setDescripcion(des);
            listaOpcionesEv = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string des) { descripcion = des; }
        public void addOpcion(OpcionesEvaluadas opcion) { listaOpcionesEv.Add(opcion); }

        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public ArrayList getOpciones() { return listaOpcionesEv; }
    }
}
