﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //necesario para declarar los arreglos

namespace TP_Diseño
{
    class Pregunta
    {
        private string pregunta;
        private string nombre;
        private string descripcion;
        private Factor factorAsociado;
        private OpciondeRespuesta Op_respuesta; // Una opcion de respuesta seria "Bueno, Muy bueno, Excelente"
        private ArrayList listaOpciones; // ej de opcion: "Excelente = 10" Excelente es el 'nombre' y 10 el 'valor'

        public Pregunta(string preg, string nom, string des, Factor fact, OpciondeRespuesta op_res)
        {
            pregunta = preg;
            factorAsociado = fact;
            setNombre(nom);
            setDescripcion(des);
            Op_respuesta = op_res;
            listaOpciones = new ArrayList();
        }

        public void setNombre(string nom) { nombre = nom; }
        public void setDescripcion(string des) { descripcion = des; }
        public void addOpcion(Opciones opcion) { listaOpciones.Add(opcion); }

        public string getPregunta() { return pregunta; }
        public string getNombre() { return nombre; }
        public string getDescripcion() { return descripcion; }
        public Factor getFactores() { return factorAsociado; }
        public ArrayList getOpciones() { return listaOpciones; }
        public OpciondeRespuesta getOp_respuesta() { return Op_respuesta; } //deberiamos devolver el objeto entero? despues ver quien llama esto y como lo usa

    }
}
