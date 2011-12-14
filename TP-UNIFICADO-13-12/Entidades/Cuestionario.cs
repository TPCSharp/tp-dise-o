﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //necesario para declarar los arreglos

namespace Entidades
{
    public class Cuestionario
    {
        private string clave;
        private int nroAccesos;
        private int maxAccesos;
        private Candidato candidatoAsociado;
        private PuestoEvaluado puestoEvaluado;
        private Bloque ultimoBloque;
        private Estado estado;

        public PuestoEvaluado PuestoEvaluado
        {
            get { return puestoEvaluado; }
            set { puestoEvaluado = value; }

        }

        public Bloque UltimoBloque
        {
            get { return ultimoBloque; }
            set { ultimoBloque = value; }

        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }

        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }

        }

        public int NroAccesos
        {
            get { return nroAccesos; }
            set { nroAccesos = value; }

        }

        public int MaxAccesos
        {
            get { return maxAccesos; }
            set { maxAccesos = value; }

        }

        public Candidato CandidatoAsociado
        {
            get { return candidatoAsociado; }
            set { candidatoAsociado = value; }

        }

        
        //Constructor 1: se ultiliza para crear un objeto por primera vez
        public Cuestionario(Candidato cand, PuestoEvaluado pEv)
        {
            //clave = ; //clave debe ser aleatoria???
            nroAccesos = 0;
            //maxAccesos = //consulta a la Administrados BD: deberia retornar este valor de la tabla de "instrucciones de sistema";
            candidatoAsociado = cand;
            puestoEvaluado = pEv;
            estado = new Estado(this, "Activo"); //this hace referencia al objeto actual
        }

        //Constructor 2: se utilizara para instanciar un obj que se encontraba en la BD
        public Cuestionario(string claveCuest, int accesos, Candidato cand, PuestoEvaluado pEv, Estado estCuest, Bloque bloq = null)
        {
            clave = claveCuest;
            nroAccesos = accesos;
            //maxAccesos = //consulta a la Administrados BD: deberia retornar este valor de la tabla de "instrucciones de sistema";
            candidatoAsociado = cand;
            puestoEvaluado = pEv;
            estado = estCuest;
            ultimoBloque = bloq;
        }

        public string obtenerEstado()
        {
            return estado.Estado_;
        }
        public DateTime obtenerFechaEstado()
        {
            return estado.Fecha_hora;
        }
        public Bloque proximoBloque(Bloque bloqAnterior)
        {
            AdministradorBD admBD = new AdministradorBD();  //intanciacion del administrador base de datos

            int nroProxBloque = bloqAnterior.NroBloque;
            nroProxBloque += 1;
            ArrayList retornoBD = admBD.retornarProximoBloque(this, nroProxBloque);
            Bloque proxBloque = (Bloque)retornoBD[0];
            this.ultimoBloque = proxBloque; //seteo el ultimo bloque
            return proxBloque;
        }

        public void aumentarAcceso()
        {
            this.nroAccesos += 1;
        }

        public void crearBloque(List<PreguntaEvaluada> listaPreguntas, int pregXbloque)
        {
            int numBloq = 0, j, contadorDeBloqueCreados = 0;
            int cantidadBloques = (listaPreguntas.Count / pregXbloque);

            for (int i = 0; i <= listaPreguntas.Count; i++)
            {
                AdministradorBD admBD = new AdministradorBD();  //intanciacion del administrador base de datos

                Bloque nuevoBloque = new Bloque(numBloq++, this);
                PreguntaEvaluada preg;
                for (j = 0; j <= pregXbloque; j++)
                {
                    preg = listaPreguntas[j];
                    nuevoBloque.addPreguntaEv(preg);
                }
                contadorDeBloqueCreados += 1;
                i += j;
                switch (contadorDeBloqueCreados == cantidadBloques)
                {
                    case true:
                        {
                            nuevoBloque.marcarUltimobloque();
                            admBD.guardarBloque(nuevoBloque); // mensaje se envia al Adm de BD
                        }
                        break;
                    default:
                        admBD.guardarBloque(nuevoBloque); // mensaje se envia al Adm de BD
                        break;
                }
            }
        }
        public void cambiarEstado(string alEstado)
        {
            AdministradorBD admBD = new AdministradorBD();  //intanciacion del administrador base de datos

            Estado nuevoEstado = new Estado(this, alEstado);
            estado = nuevoEstado;
            admBD.guardarEstado(estado); //se lo envia al Adm BD
        }
    }
}