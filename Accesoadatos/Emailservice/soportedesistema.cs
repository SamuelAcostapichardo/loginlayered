using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesoadatos.Emailservice
{
    class soportedesistema:servermasteremail 
    {
        public soportedesistema()
        {

            senderMail = "samuel0221fire@gmail.com";
            Password = "bingoybugui18anos";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarsmtpcliente();
        }



    }
}
