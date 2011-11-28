using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    class FactorEvaluado
    {
        private int codigo;
        private string nombre;
        private CompetenciaEvaluada competenciaAsociada;
        private string descripcion;
        private int nro_orden;
        private ArrayList listaPreguntasEv;


        //Competencia -> Factor -> Pregunta
        public FactorEvaluado(int cod, string nom, CompetenciaEvaluada comp, string des, int nOrden)
        {
            codigo = cod;
            competenciaAsociada = comp;
            setNombre(nom);
            setDescripcion(des);
            setNrOrden(nOrden);
            listaPreguntasEv = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string desc) { descripcion = desc; }
        public void setNrOrden(int nOrd) { nro_orden = nOrd; }
        public void addPregunta(PreguntaEvaluada preg) { listaPreguntasEv.Add(preg); }

        public int getCodigo() { return codigo; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public int getNrOrden() { return nro_orden; }
        public ArrayList getPreguntas() { return listaPreguntasEv; }
    }
}

