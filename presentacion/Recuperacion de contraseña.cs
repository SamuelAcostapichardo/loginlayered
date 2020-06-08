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

namespace presentacion
{
    public partial class Recuperacion_de_contraseña : Form
    {
        public Recuperacion_de_contraseña()
        {
            InitializeComponent();
        }

        private void btnrecovery_Click(object sender, EventArgs e)
        {
            var usuario = new usuariodominio();
            var resultado = usuario.passwordrecovery(txtemailornombre.Text);
            lblresultado.Text = resultado;
            txtemailornombre.Clear();
            
        }
    }
}
