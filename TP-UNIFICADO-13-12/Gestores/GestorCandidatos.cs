using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Entidades;
using System.Windows.Forms;

namespace Gestores
{
    public class GestorCandidatos
    {
        //Declaracion de una instancia de gestores para poder hacerles consultas
        AdministradorBD admBD = new AdministradorBD();
        GestorCuestionario gestorCuestionario = new GestorCuestionario();

        public List<Candidato> listarCandidatos(string apellido, string nombre, int nroEmpleado = 0, int nroCandidato = 0)
        {
            ArrayList retornoBD = admBD.recuperarCandidatos(null, null, nombre, apellido, nroEmpleado, nroCandidato);
            List<Candidato> listaCandidatos = new List<Candidato>();

            for (int i = 0; i <= retornoBD.Count; i++)
            {
                Candidato cand = (Candidato)retornoBD[i];
                listaCandidatos.Add(cand);
            }

            return listaCandidatos;
        }

        public void validarCandidato(string TipoDoc, int NroDoc, string clave)
        {
            ArrayList retornoBD = admBD.recuperarCandidato(TipoDoc, NroDoc);
            Candidato nuevoCandidato = (Candidato)retornoBD[0];

            switch (nuevoCandidato is Candidato)
            {
                case true:
                    Cuestionario cuestAsociado = gestorCuestionario.cuestionarioAsociado(nuevoCandidato);
                    if (cuestAsociado is Cuestionario)
                    {
                        gestorCuestionario.validarAcceso(cuestAsociado, clave);
                    }
                    else
                        MessageBox.Show("El candidato no Poseé un cuestionario para ser evaluado");
                    break;
            }         
        }

        public void validarCandidatoPasaporte(string TipoDoc, string NroDoc, string clave)
        {
            ArrayList retornoBD = admBD.recuperarCandidatos(TipoDoc, NroDoc);
            Candidato nuevoCandidato = (Candidato)retornoBD[0];

            switch (nuevoCandidato is Candidato)
            {
                case true:
                    Cuestionario cuestAsociado = gestorCuestionario.cuestionarioAsociado(nuevoCandidato);
                    break;
            }
        }
    }
}
