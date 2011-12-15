using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TpDiseñoCSharp
{
    public partial class Gestionar_Puestos : Form
    {
        public Gestionar_Puestos(string user)
        {
            InitializeComponent();
            this.Consultor.Text = user;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Alta_De_Puesto altaPuesto = new Alta_De_Puesto(this.Consultor.Text, this);
            altaPuesto.ShowDialog();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            /*BUSCA LOS PUESTOS O FUNCIONES DE ACUERDO A LOS FILTROS ESPECIFICADOS PARA PODER MODIFICARLOS Y ELIMINAR
             Y LOS MUESTRA EN UNA TABLA*/
           
            /*Habilitar cuando se haya integrado las interfaces con lo demas*/
            //dataGridView1.DataSource = listaActores;

            listaDePuesto.Visible = true;
            
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Modificar_Puesto_o_Funcion modificarPuesto = new Modificar_Puesto_o_Funcion(this.Consultor.Text, this);
            modificarPuesto.ShowDialog();
        }
    }
}
