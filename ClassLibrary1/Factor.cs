using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    class Factor
    {
        private int codigo;
        private string nombre;
        private Competencia competenciaAsociada;
        private string descripcion;
        private int nro_orden;
        private ArrayList listaPreguntas;

        //Competencia -> Factor -> Pregunta
        public Factor(int cod, string nom, Competencia comp, string des, int nOrden)
        {
            codigo = cod;
            competenciaAsociada = comp;
            setNombre(nom);
            setDescripcion(des);
            setNrOrden(nOrden);
            listaPreguntas = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string desc) { descripcion = desc; }
        public void setNrOrden(int nOrd) { nro_orden = nOrd; }
        public void addPregunta(Pregunta preg) { listaPreguntas.Add(preg); }

        public int getCodigo() { return codigo; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public int getNrOrden() { return nro_orden; }
        public ArrayList getPreguntas() { return listaPreguntas; }
    }
}
