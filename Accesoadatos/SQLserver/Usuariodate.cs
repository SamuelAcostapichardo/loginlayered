using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capacomun.Cache;

namespace Accesoadatos
{
    public class Usuariodate : Conexionsql
    {

    //  public bool login(string usuario, string password)
      //  {
        //    using (var conection = Getconection())
         //   {
           //     conection.Open();
             //   using (var command = new SqlCommand())
             //   {
               //     command.Connection = conection;
               //     command.CommandText = "select *from usuarios where usuario = @usuario and password=@password";
               //     command.Parameters.AddWithValue("@usuario",usuario);
               //     command.Parameters.AddWithValue("@Password", password);                     
               //     command.CommandType = CommandType.Text;
               //     SqlDataReader reader = command.ExecuteReader();
               //     if (reader.HasRows)
               //     {
               //         while (reader.Read())
               //         {
              //              iniciodesesioncache.id_usuario = reader.GetInt32(0);
              //              iniciodesesioncache.nombre = reader.GetString(1);
              //              iniciodesesioncache.tipo_usuario = reader.GetString(4);
              //              iniciodesesioncache.Email = reader.GetString(5);
              //          }
              //          return true;
              //      }
              //      else
              //          return false;
              //  }
           // }

     // }



        public bool Login(string usuario, string password)
        {
            using (var conection = Getconection())
            {
                conection.Open();
                
               
                   
                    string  Command = "select * from usuarios, Roles, Modulos, Detalle_modulos where nombreusuario = '" +usuario +"' and claveusuario = '"+ password+"'";
                    DataTable reader = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(Command,conection);
                    da.Fill(reader);

                    if (reader.Rows.Count >0 )
                    {

                     iniciodesesioncache.Nombrerol = reader.Rows[0]["Codigorol"].ToString();
                     iniciodesesioncache.nombre = reader.Rows[0]["nombreusuario"].ToString();
                     iniciodesesioncache.Estatusrol = reader.Rows[0]["estatusrol"].ToString();
                     iniciodesesioncache.Estatusmod = reader.Rows[0]["estatusmod"].ToString();
                     iniciodesesioncache.Email =reader.Rows[0]["nombrecompleto"].ToString();
                     iniciodesesioncache.acceder =bool.Parse (reader.Rows[0]["acceder"].ToString());

                     // iniciodesesioncache.id_usuario = reader.GetInt32(0);
                     // iniciodesesioncache.nombre = reader.GetString(1);
                     // iniciodesesioncache.tipo_usuario = reader.GetString(4);
                     // iniciodesesioncache.Email = reader.GetString(5);



                    return true;
                    }
                    else
                        return false;
                
            }

        }

        public string passwordrecovery(string usuariopregunta)
        {
            using (var conection = Getconection ())
            {
                conection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conection;
                    command.CommandText = "select *from usuarios where usuario=@usuario or Email=@Email";
                    command.Parameters.AddWithValue("@usuario", usuariopregunta);
                    command.Parameters.AddWithValue("@Email",usuariopregunta);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string nombreusuario = reader.GetString(2) + ", " + reader.GetString(1);
                        string emailusuario = reader.GetString(5);
                        string contraseña = reader.GetString(3);

                        var soportedesistema = new Emailservice.soportedesistema();
                        soportedesistema.sendMail(
                            subject: "SYSTEM: recuperacion de contraseña",
                            body: "Hola" + nombreusuario + "\n solicitud de recuperacion de contraseña.\n" +
                            "your current pasword is: " + contraseña +
                            "\n Debe cambiar la contraseña despues que inicie sesion en el sistema.",
                            recipienteMail: new List<string> { emailusuario }
                            );
                        return "Hola" + nombreusuario + "\n pediste una recuperacion de tu contraseña.\n" +
                            "Por favor revise su correo:" + emailusuario + "\n Debe cambiar su contraseña inmediatamente inisie sesion en el systema.";

                    }
                    else
                        return "Lo sentimos al parecer no tiene una cuenta registrada con nosotros";
                }
            }

        }





        //
        public void metodoseguro() { 
        
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
