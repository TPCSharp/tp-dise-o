using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Data;

namespace Entidades
{
    //el codigo del administrador no esta bien implementado. Ver Implementacion de BD
    public class AdministradorBD
    {
        private MySqlConnection ObjConexion = new MySqlConnection();
        private String connectionString;

        private bool iniciarConexion()
        {
            try
            {
                connectionString = "Server=127.0.0.1; Database=tp base de datos; Uid=root; Pwd=root;";
                ObjConexion.ConnectionString = connectionString;

                ObjConexion.Open();

                return true;

            }

            catch
            {
                return false;

            }
        }

        private void terminarConexion()
        {
            if (ObjConexion.State == ConnectionState.Open)
                ObjConexion.Close();
        }

        public ArrayList recuperarPuestos(string codigo = null, string nombre = null, string empresa = null)
        {
            ArrayList retornoBD = new ArrayList();

            

            return retornoBD;
        }

        
        public ArrayList recuperarCandidato(string TipoDoc, int NroDoc)
        {
            bool conexionExitosa;
            
            string consultaSql = "SELECT * FROM candidato WHERE  `nro documento` = '"+NroDoc+"' AND `tipo documento` = '"+TipoDoc+"';";
            
            conexionExitosa = iniciarConexion();
            
            if (!conexionExitosa) 
                return null;
            
            MySql.Data.MySqlClient.MySqlCommand comando;
            
            comando = ObjConexion.CreateCommand();
            
            comando.CommandText = consultaSql;

            MySqlDataReader reader = comando.ExecuteReader();

            ArrayList listaCandidatos = new ArrayList();
            while (reader.Read())
            {
                string nom = reader["nombre"].ToString();
                string ape = reader["apellido"].ToString();
                string tipoDoc = reader["tipo documento"].ToString();
                string nroDoc = reader["nro documento"].ToString();

                int nroCandidato;
                if (reader["nroCandidato"].ToString() == "")
                    nroCandidato = 0;
                else
                    nroCandidato = Int32.Parse(reader["nroCandidato"].ToString());

                int nroEmpleado;
                if (reader["nroEmpleado"].ToString() == "")
                    nroEmpleado = 0;
                else
                    nroEmpleado = Int32.Parse(reader["nroEmpleado"].ToString());

                Candidato objCandidato = new Candidato(nom, ape, tipoDoc, nroDoc, nroCandidato, nroEmpleado);
                listaCandidatos.Add(objCandidato);
             }




            terminarConexion();

            //-------------------------------------------
            
            return listaCandidatos;
        }

        //genera un comando (con la consulta que se pasa de parametro) para realizar una transaccion
        private MySql.Data.MySqlClient.MySqlCommand crearComando(string consultaSql)
        {
            MySql.Data.MySqlClient.MySqlCommand comando = new MySqlCommand();

            comando.Connection = ObjConexion;
            comando.CommandType = CommandType.Text;
            comando.CommandTimeout = 0;
            comando.CommandText = consultaSql;

            return comando;
        }

        //este es para pasaporte
        public ArrayList recuperarCandidatos(string TipoDoc = null, string NroPasap = null, string nombre = null, string apellido = null, int nroEmp = 0, int nroCand = 0)
        {
            //si todo es por defecto devolver TODOs los candidatos
            if (TipoDoc == null && NroPasap == null && nombre == null && apellido == null && nroEmp == 0 && nroCand == 0)
            {
                bool conexionExitosa;

                string consultaSql = "SELECT * FROM candidato";

                conexionExitosa = iniciarConexion();

                if (!conexionExitosa)
                    return null;

                MySql.Data.MySqlClient.MySqlCommand comando;

                comando = ObjConexion.CreateCommand();

                comando.CommandText = consultaSql;

                MySqlDataReader reader = comando.ExecuteReader();

                ArrayList listaCandidatos = new ArrayList();
                while (reader.Read())
                {
                    string nom = reader["nombre"].ToString();
                    string ape = reader["apellido"].ToString();
                    string tipoDoc = reader["tipo documento"].ToString();
                    string nroDoc = reader["nro documento"].ToString();

                    int nroCandidato;
                    if (reader["nroCandidato"].ToString() == "")
                        nroCandidato = 0;
                    else
                        nroCandidato = Int32.Parse(reader["nroCandidato"].ToString());

                    int nroEmpleado;
                    if (reader["nroEmpleado"].ToString() == "")
                        nroEmpleado = 0;
                    else
                        nroEmpleado = Int32.Parse(reader["nroEmpleado"].ToString());

                    //int nroEmpleado = Int32.Parse(reader["nroEmpleado"].ToString());
                    
                        

                    Candidato objCandidato = new Candidato(nom, ape, tipoDoc, nroDoc, nroCandidato, nroEmpleado);
                    listaCandidatos.Add(objCandidato);
                }

                terminarConexion();

                return listaCandidatos;
            }//fin de if(TODO ES NULL)

            //string TipoDoc string NroPasap string nombre string apellido int nroEmp  int nroCand
            string consultaSql2 = "SELECT * FROM candidato WHERE ";

            if (TipoDoc != null)
            {
                consultaSql2 += "`tipo documento` = '" + TipoDoc + "';";
            }

            

            ArrayList retornoBD = new ArrayList();
            return retornoBD;
        }


        public ArrayList recuperarCuestionario(Candidato candidato)
        {
            ArrayList retornoBD = new ArrayList();
            return retornoBD;
        }

        public ArrayList recuperarCompetencias()
        {
            ArrayList retornoBD = new ArrayList();
            return retornoBD;
        }

        //Metodos de resguardo de clases
        public void guardarPuesto(Puesto puesto) { }
        public void guardarRespuesta(Respuestas respuesta) { }
        public void guardarEstado(Estado estado) { }
        public void guardarBloque(Bloque nuevoBloque) { }

        //Metodos de consulta de existencia de clases
        public bool existePuesto(string codigo = null, string nombre = null)
        {
            bool seConecto;

            seConecto = iniciarConexion();

            //aca va la magia del metodo

            terminarConexion();


            return seConecto; //retorno de prueba

            
        }

        public int preguntasPorBloque()
        {
            int valor = 0; // este valor se consulta en la tabla de instrucciones del sistema
            return valor;
        }

        /*retorna el tiempo en dias (entero) para realizar la evaluaciones,
         se tomara este valor de la tabla 'Instrucciones de Sistema' de la BD*/
        public int darTiempoEvaluacion()
        {
            int tiempoEvaluacion = 15; //ejemplo hasta hacer la implementacion real
            return tiempoEvaluacion;
        }

        /*retorna el tiempo en dias (entero) para completar el cuestionario desde que se inicia,
         se tomara este valor de la tabla 'Instrucciones de Sistema' de la BD*/
        public int darTiempoActivo()
        {
            int tiempoActivo = 15; //ejemplo hasta hacer la implementacion real
            return tiempoActivo;
        }

        public ArrayList retornarProximoBloque(Cuestionario cuest, int nroProxBloque)
        {
            ArrayList retornoBD = new ArrayList();
            return retornoBD;
        }

    }
}
