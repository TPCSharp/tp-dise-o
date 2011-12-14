using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gestores;

namespace TpDiseñoCSharp
{
    public partial class LoginCandidato : Form
    {
        GestorCandidatos gestorCandidatos = new GestorCandidatos();

        public LoginCandidato()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            int NroDocumento = Int32.Parse(NroDoc.Text.ToString());
            gestorCandidatos.validarCandidato(comboBoxTipoDNI.Text.ToString(), NroDocumento, Clave.Text.ToString());
 
            /*Hacer la validación primero de si son correctos los datos ingresados como caracteres alfanumericos, etc
             y luego mandar a validar al gestor*/
            //validarCandidato(String TipoDoc,int NroDoc,String clave)
            //validarCandidatoPasaporte(String TipoDoc,String NroDoc,String clave)

            Close();
            //Si la validación anterior es correcta hacer lo siguiente
            Cuestionario_Instrucciones cuestInstruc = new Cuestionario_Instrucciones();
            cuestInstruc.Show();
        }


        //Si presiona el boton cancelar, se cierra la ventana "LoginCandidato" y vuelve a la "PantallaPrincipal"
        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
