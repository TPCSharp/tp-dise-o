using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //necesario para declarar los arreglos

namespace TP_Diseño
{
    class Cuestionario
    {
        private int clave;
        private int nroAccesos;
        private int maxAccesos;
        private Candidato candidatoAsociado;
        internal PuestoEvaluado puestoEvaluado;
        internal Bloque ultimoBloque;
        internal Estado estado;

        //Constructor 1: se ultiliza para crear un objeto por primera vez
        public Cuestionario(Candidato cand, PuestoEvaluado pEv)
        {
            nroAccesos = 0;
            //maxAccesos = //consulta a la Administrados BD: deberia retornar este valor de la tabla de "instrucciones de sistema";
            candidatoAsociado = cand;
            puestoEvaluado = pEv;
            estado = new Estado(this, "Activo"); //this hace referencia al objeto actual
        }

        //Constructor 2: se utilizara para instanciar un obj que se encontraba en la BD
        public Cuestionario(int accesos, Candidato cand, PuestoEvaluado pEv, Estado estCuest, Bloque bloq)
        {
            nroAccesos = accesos;
            //maxAccesos = //consulta a la Administrados BD: deberia retornar este valor de la tabla de "instrucciones de sistema";
            candidatoAsociado = cand;
            puestoEvaluado = pEv;
            estado = estCuest;
            ultimoBloque = bloq;
        }

        public PuestoEvaluado getEvaluacion() { return puestoEvaluado; }

        public void crearBloque(ArrayList listaPreguntas, int pregXbloque)
        {
            int numBloq = 0, j;
            for (int i = 0; listaPreguntas[i] != null; i++)
            {
                Bloque nuevoBloque = new Bloque(numBloq++, this);
                PreguntaEvaluada preg;
                for (j = 0; j <= pregXbloque; j++)
                {
                    preg = (listaPreguntas[j] as PreguntaEvaluada);//con as realizo la conversin del retorno de la lista a pregunta evaluada
                    nuevoBloque.addPreguntaEv(preg);
                }
                i += j;
                //guardarBloque(nuevoBloque); mensaje se envia al Adm de BD
            }
        }

        public void cambiarEstado(string alEstado)
        {
            Estado nuevoEstado = new Estado(this, alEstado);
            estado = nuevoEstado;
            //guardarEstado(estado); se lo envia al Adm BD
        }
    }
}
