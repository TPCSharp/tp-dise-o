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
    public partial class MenuPrincipalConsultor : Form
    {
        public MenuPrincipalConsultor()
        {
            InitializeComponent();
        }

        private void EmitirOrdenDeMerito_Click(object sender, EventArgs e)
        {
            Emitir_Orden_de_Mérito ordenDeMerito = new Emitir_Orden_de_Mérito();
            ordenDeMerito.ShowDialog();
        }

        /*=====================================================
          ESTAS FUNCIONALIDADES NO SON IMPLEMENTADAS EN EL TP
          =====================================================*/

        private void ImportarCandidatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void EvaluarCandidatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void ExportarResultados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void EmitirReporteComparativo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void Competencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void Factores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void Preguntas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }

        private void OpcionesDeRespuesta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidad no ha sido implementada");
        }
        /*=====================================================
              FIN DE FUNCIONALIDADES QUE NO SON IMPLEMENTADAS
          =====================================================*/


        private void PuestoFunciones_Click(object sender, EventArgs e)
        {
            Gestionar_Puestos gestPuesto = new Gestionar_Puestos();
            gestPuesto.ShowDialog();
        }
    }
}
