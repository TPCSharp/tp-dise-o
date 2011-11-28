using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    struct Caracteristica 
    { 
        public Competencia competencias; 
        public Ponderacion valor;
    }

    class Puesto
    {
        //Atributos de la clase Puesto
        private int codigo;
        private string nombre;
        private string empresa;
        private string descripcion;
        private ArrayList caracteristicas;

        /* Metodo Constructor */
        public Puesto(int cod, string nomb, string emp, string desc)
        {
            codigo = cod; //el codigo es seteado unicamente al iniciar el Puesto.
            setNombre(nomb);
            setEmpresa(emp);
            setDescripcion(desc);
            caracteristicas = new ArrayList();
        }

        //Metodos de inicializacion y modificación 
        public void setNombre(string nomb) { nombre = nomb; }
        public void setEmpresa(string empr) { empresa = empr; }
        public void setDescripcion(string desc) { descripcion = desc; }
        
        public void addListaCaracteristicas(Competencia comp, Ponderacion pond)
        {
            Caracteristica elemento;
            elemento.competencias = comp;
            elemento.valor = pond;
            caracteristicas.Add(elemento);
        }


        //Metodos de retorno
        public int getCodigo() { return codigo; }
        public string getNombre() { return nombre; }
        public string getEmpresa() { return empresa; }
        public ArrayList getCaracteristicas() { return caracteristicas; }

    }

}
