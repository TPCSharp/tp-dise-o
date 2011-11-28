using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Diseño
{
    class Candidato
    {
        private string nombre, apellido;
        private int DNI, nroCandidato, nroEmpleado;

        //CONSTRUCTOR
        public Candidato(string nom, string apell, int dni, int nroCand = 0, int nroEmp = 0)//el cero indica que puede ser nulo el valor recibido
        {
            nombre = nom;
            apellido = apell;
            DNI = dni;
            nroCandidato = nroCand;
            nroEmpleado = nroEmp;
        }

        public string getNombre() { return nombre; }
        public string getApellido() { return apellido; }
        public int getDni() { return DNI; }
        public int getNroEmpleado() { return nroEmpleado; }
        public int getNroCandidato() { return nroCandidato; }

    }
}
