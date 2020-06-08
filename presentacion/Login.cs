using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominios;
using capacomun.Cache;


namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;

            }
        }

        private void Txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text =="")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void Txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "PASSWORD")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = true;

            }
        }

        private void Txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "PASSWORD";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "USUARIO") {
                if (txtpassword.Text != "PASSWORD"){
                    usuariodominio user = new usuariodominio();
                    var validologin = user.loginusuario(txtusuario.Text,txtpassword.Text);
                    if (validologin == true)
                    {
                         Formularioprincipal D = new Formularioprincipal ();
                        MessageBox.Show("Bienvenido   "+iniciodesesioncache.nombre+ ", " +iniciodesesioncache.tipo_usuario );
                        D.Show();
                        D.FormClosed += Cerrarsesion;
                        this.Hide();
                    }
                    else Msgerror("Usuario o contraseña incorrectos.\n por favor intente de nuevo");
                    txtpassword.Clear();
                    txtusuario.Focus(); 
                }
                 else Msgerror("porfavor introdusca la contraseña");
        }
            else Msgerror("Por favor introdusca su nombre de usuario ");
        }
        private void Msgerror(string msg)
        {
            lblmsg.Text = "" + msg;
            lblmsg.Visible = true;
        }
        private void Cerrarsesion(object sender, FormClosedEventArgs e)
        {
            txtpassword.Clear();
            txtusuario.Clear();
            lblmsg.Visible = false;
            this.Show();
            txtusuario.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recuperarcontraseña = new Recuperacion_de_contraseña();
            recuperarcontraseña.ShowDialog();
        }

        
    }
}
