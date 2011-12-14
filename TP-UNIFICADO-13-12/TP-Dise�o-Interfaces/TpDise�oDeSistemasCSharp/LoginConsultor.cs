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
    public partial class LoginConsultor : Form
    {
        public LoginConsultor()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            MenuPrincipalConsultor menuConsultor = new MenuPrincipalConsultor();
            menuConsultor.ShowDialog();
        }

        //Si presiona el boton cancelar, se cierra la pantalla "LoginConsultor" y se vuelve a la "PantallaPrincipal"
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
