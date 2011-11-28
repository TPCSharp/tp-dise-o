using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_Diseño
{
    class Estado
    {
        private string estado;
        private DateTime fecha_hora;
        private Cuestionario cuestionario;

        //Contructor de clase 1: se lo llamara si se esta instanciando un obj para la clase que ya exista en la BD
        public Estado(Cuestionario cuest, string est, DateTime fecha) 
        {
            cuestionario = cuest;
            estado = est;
            fecha_hora = fecha;
        }

        //Constructor de clase 2: se llamara si se esta instanciando un obj por primera vez.
        public Estado(Cuestionario cuest, string est)
        {
            cuestionario = cuest;
            estado = est;
            fecha_hora = DateTime.Now;
        }

        public DateTime getFecha() { return fecha_hora; }
        public string getEstado() { return estado; }
    }
}
