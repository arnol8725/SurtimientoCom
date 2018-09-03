using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Elektra.Negocio.EktCom.WSElektraCom;
namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int Sku{ get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public double Precio { get; set; }

        [DataMember]
        public int IdPromocion { get; set; }
        [DataMember]
        public decimal Descuento { get; set; }

    }
}