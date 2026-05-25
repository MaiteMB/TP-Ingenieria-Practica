using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Ingenieria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                lblMensaje.Text = "Ingrese usuario y clave para continuar.";
                return;
            }

            lblMensaje.Text = "Login pendiente de conectar con la capa BLL.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
