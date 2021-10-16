using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.Mensajeria.BL
{
    public  interface IMensajeria
    {
        /// <summary>
        /// Esta interface se encarga de enviar y recibir mensajes
        /// Es para el curso Topicos 
        /// </summary>
        /// <param name="elMensaje"> Mensaje para enviar </param>
        public void Enviar(Mensaje elMensaje);

        /// <summary>
        /// Para leer los mensajes del buzon 
        /// </summary>
        /// <param name="Propietario">Nombre del dueño del recipiente del que se quiere leer el mensaje</param>
        /// <reutrns>Lista de todos los mensajes del buzon</reutrns>
        public IList<Mensaje> Leer(string Propietario);


        /// <summary>
        /// Variable con el mensaje para enviar 
        /// TODO:Valorar Borrarla
        /// </summary>
        public Mensaje elMensajeParaEnviar { get; set; }
        
    }
}
