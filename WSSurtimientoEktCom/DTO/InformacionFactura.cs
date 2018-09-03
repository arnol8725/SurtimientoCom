using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Elektra.Negocio.EktCom.WSElektraCom;
namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class InformacionFactura
    {
        [DataMember]
        public bool RequiereFactura { get; set; }
    }
}