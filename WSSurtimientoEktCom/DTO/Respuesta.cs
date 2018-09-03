using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public bool EsError { get; set; }

        [DataMember]
        public string MensajeTecnico { get; set; }

        [DataMember]
        public string MensajeUsuario { get; set; }
    }
}