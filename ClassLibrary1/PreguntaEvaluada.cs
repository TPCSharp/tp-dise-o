using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    class PreguntaEvaluada
    {
        private string pregunta;
        private string nombre;
        private string descripcion;
        private FactorEvaluado factorAsociado;
        private OpciondeRespuestaEvaluada Op_respuestaEv; // Una opcion de respuesta seria "Bueno, Muy bueno, Excelente"
        private ArrayList listaOpcionesEv; // ej de opcion: "Excelente = 10" Excelente es el 'nombre' y 10 el 'valor'

        public PreguntaEvaluada(string preg, string nom, FactorEvaluado fact, string des, OpciondeRespuestaEvaluada Op_res_Ev)
        {
            pregunta = preg;
            factorAsociado = fact;
            setNombre(nom);
            setDescripcion(des);
            Op_respuestaEv = Op_res_Ev;
            listaOpcionesEv = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string des) { descripcion = des; }
        public void addOpcion(OpcionesEvaluadas opcion) { listaOpcionesEv.Add(opcion); }

        public string getPregunta() { return pregunta; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public FactorEvaluado getFactores() { return factorAsociado; }
        public OpciondeRespuestaEvaluada getOpRespuesta() { return Op_respuestaEv; }
        public ArrayList getOpciones() { return listaOpcionesEv; }
    }
}
