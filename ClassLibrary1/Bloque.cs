using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace TP_Diseño
{
    //Un bloque pertenece a un cuestionario especifico.
    class Bloque
    {
        private int nroBloque; //numero de identificacion del bloque [ej: 1]
        private Cuestionario cuestAsociado;
        private ArrayList listaPreguntasEv; //preguntas que estan contenidas dentro del bloque

        //constructor
        public Bloque(int nro_Bloq, Cuestionario cuest) { nroBloque = nro_Bloq; cuestAsociado = cuest; listaPreguntasEv = new ArrayList(); }
        
        public void addPreguntaEv(PreguntaEvaluada preguntaEv) { listaPreguntasEv.Add(preguntaEv); } //este es el metodo de contruccion de la lista de preguntas

        public int getNroBloque() { return nroBloque; }
        public Cuestionario getCuestionario() { return cuestAsociado; }
        public ArrayList getPreguntas() { return listaPreguntasEv; }
    }
}
