using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Validacion;


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
            /*if (!validarAlphanum.validarCamposAlfanum(Usuario.Text))
            {
                if (!validarAlphanum.validarCamposAlfanum(Contraseña.Text))
                {
                    if (Contraseña.Text.Length > 7)
                    {*/
                        MenuPrincipalConsultor menuConsultor = new MenuPrincipalConsultor(Usuario.Text);
                        menuConsultor.ShowDialog();
                   /* }
                    else
                    {
                        MessageBox.Show("La contraseña debe ser de 8 caracteres como mínimo", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        limpiarTextBoxFormulario(this);
                        this.ActiveControl = Usuario;

                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no son válidos","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                    limpiarTextBoxFormulario(this);
                    this.ActiveControl = Usuario;
                }
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no son válidos", "Mensaje de Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTextBoxFormulario(this);
                this.ActiveControl = Usuario;
            }
            */
        }

        //Si presiona el boton cancelar, se cierra la pantalla "LoginConsultor" y se vuelve a la "PantallaPrincipal"
        private void Cancelar_Click(object sender, EventArgs e)
        {
            
            Close();
        }
       



       // Declaramos nuestro metodo que hara la limpieza de los textbox
        private void limpiarTextBoxFormulario(Form formulario)
        {
            // hace un chequeo por todos los textbox del formulario
            foreach(Control controlDeFormulario in formulario.Controls)
            {
                if (controlDeFormulario is GroupBox)
                {
                    foreach (Control controlTextBox in controlDeFormulario.Controls)
                    {
                        if (controlTextBox is TextBox)
                        {
                            controlTextBox.Text = null;
                        }
                    }
                }
            }
        }
      

    }
}
