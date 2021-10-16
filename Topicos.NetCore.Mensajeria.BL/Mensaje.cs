using System;

namespace Topicos.NetCore.Mensajeria.BL
{
    public class Mensaje
    {

        public Mensaje()
        {

        }

        public Mensaje(string Remitente, string Destinatario, string Texto)
        {
            this.Remitente = Remitente;
            this.Destinatario = Destinatario;
            this.Texto = Texto;
        }

       
        /// <summary>
        /// Nombre de quien envia el mensaje
        /// </summary>
        public string Remitente;

        /// <summary>
        /// Nombre de quien recibe el mensaje
        /// </summary>
        public string Destinatario;

        /// <summary>
        /// Cuerpo del mensaje
        /// </summary>
        /// 
        public string Texto;
    }
}
