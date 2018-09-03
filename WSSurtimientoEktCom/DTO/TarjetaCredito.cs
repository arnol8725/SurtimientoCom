using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class TarjetaCredito
    {
        [DataMember]
        public string BancoAdquirente { get; set; }

        [DataMember]
        public string Fecha { get; set; }

        [DataMember]
        public string FolioAutorizacion { get; set; }

        [DataMember]
        public string Hora { get; set; }

        [DataMember]
        public string ImportePedido { get; set; }

        [DataMember]
        public string NombreTarjetaHabiente { get; set; }

        [DataMember]
        public string NumeroAfiliacion { get; set; }

        [DataMember]
        public string NumeroPedido { get; set; }

        [DataMember]
        public string NumeroTDC { get; set; }

        [DataMember]
        public string TerminosCondiciones { get; set; }

        [DataMember]
        public string TerminosCondiciones2 { get; set; }

        [DataMember]
        public string TerminosCondiciones3 { get; set; }
    }
}