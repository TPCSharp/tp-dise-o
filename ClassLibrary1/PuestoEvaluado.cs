using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP_Diseño
{
    struct ArregloElementosEvaluados
    {
        public CompetenciaEvaluada competencia;
        public Ponderacion valor;
    }

    class PuestoEvaluado
    {
        //Atributos de la clase Puesto
        private int codigo;
        private string nombre;
        private string empresa;
        private string descripcion;
        private ArrayList caracteristicas;
        private DateTime fechaComienzo;// tiene q ser la misma del estado activo del cuestionario

        /* Metodo Constructor */
        public PuestoEvaluado(int cod, string nomb, string emp, string desc)
        {
            codigo = cod; //el codigo es seteado unicamente al iniciar el Puesto.
            fechaComienzo = new DateTime(); //mirar como inicializar esta variable !!!! 
            setNombre(nomb);
            setEmpresa(emp);
            setDescripcion(desc);
            caracteristicas = new ArrayList();
        }

        //Metodos de inicializacion y modificación 
        public void setNombre(string nomb) { nombre = nomb; }
        public void setEmpresa(string empr) { empresa = empr; }
        public void setDescripcion(string desc) { descripcion = desc; }
        public void addListaCaracteristicas(CompetenciaEvaluada comp, Ponderacion pond)
        {
            ArregloElementosEvaluados elemento;
            elemento.competencia = comp;
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
