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
    public partial class Modificar_Puesto_o_Funcion : Form
    {
        private Gestionar_Puestos ventanaAnterior; 
        public Modificar_Puesto_o_Funcion(string User, Gestionar_Puestos gestPuesto)
        {
            ventanaAnterior = gestPuesto;
            InitializeComponent();
            this.Consultor.Text = User;

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            ventanaAnterior.Close();
            Close();
        }
    }
}
