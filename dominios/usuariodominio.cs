using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accesoadatos;
using capacomun.Cache;
namespace dominios
{
    public class usuariodominio
    {
        Usuariodate usuariodate = new Usuariodate();
        public bool loginusuario(string usuario, string password)
        {
            return usuariodate.Login(usuario, password);
        }
        public string passwordrecovery(string recoverypassword )
        {
            return usuariodate.passwordrecovery(recoverypassword);
        }
        
        public void metodoseguro()
        {
            //security posiciones
            if (iniciodesesioncache.tipo_usuario == cargos.Administrador)
            {
                //codes
            }

            if (iniciodesesioncache.tipo_usuario == cargos.DB || iniciodesesioncache.tipo_usuario == cargos.Presidente)
            {
                //codes
            }

        }
    }
}
