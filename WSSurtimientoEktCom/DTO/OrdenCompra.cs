using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Elektra.Negocio.EktCom.WSElektraCom;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class OrdenCompra: Respuesta
    {
        [DataMember]
        public PedidoEktCom InfoOrdenCompraEktCom { get; set; }

        [DataMember]
        public bool EsPedidoRelacionado { get; set; }

        [DataMember]
        public long Pedido { get; set; }

        [DataMember]
        public string  cadenaVoucher { get; set; }
    }
}