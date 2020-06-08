using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capacomun.Cache;


namespace presentacion
{
    public partial class Formularioprincipal : Form
    {
        public Formularioprincipal()
        {
            InitializeComponent();
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea serrar sesion?", "warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            {

            }
        }

        private void cargardatosuser()
        {
            lblusuario.Text = iniciodesesioncache.nombre;
            lbltipousuario.Text = iniciodesesioncache.Nombrerol;
            lblemail.Text = iniciodesesioncache.Email;
            
        }
         
        private void roles()
        {
            if (iniciodesesioncache.Nombrerol == cargos.Administrador)
            {
                btninventario.Enabled = false;
                btninicio.Enabled = false;
                button1.Enabled = iniciodesesioncache.acceder;



            }
         
            if (iniciodesesioncache.tipo_usuario == cargos.DB)
            {
                btnsuplidor.Enabled = false;
                button1.Enabled = iniciodesesioncache.acceder;
            }
            if (iniciodesesioncache.tipo_usuario == cargos.Administrador)
            {
                btninventario.Enabled = false;
                btninicio.Enabled = false;
                button1.Enabled = iniciodesesioncache.acceder;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            cargardatosuser();
            roles();
        
        }

        private void btncliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelopcion.Visible == false)
            {

                panelopcion.Show();

            }
            else
            {
                panelopcion.Visible = false;
            }
        }
    }
}
