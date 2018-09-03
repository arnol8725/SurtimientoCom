using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class PedidoEktCom
    {
        public PedidoEktCom(){}

        [DataMember]
        public string Beneficiario1 { get; set; }

        [DataMember]
        public string Beneficiario2 { get; set; }

        [DataMember]
        public int Canal { get; set; }

        [DataMember]
        public bool CanPrintOrderVoucherInfo { get; set; }

        [DataMember]
        public string DescNegocioTipoVenta { get; set; }

        [DataMember]
        public string DescripcionStatus { get; set; }

        [DataMember]
        public bool ImprimirVoucher { get; set; }

        [DataMember]
        public InformacionCliente InformacionCliente { get; set; }

        [DataMember]
        public bool IsEmployeeSale { get; set; }

        [DataMember]
        public bool IsFromCreditApplication { get; set; }

        [DataMember]
        public string NegocioTipoVenta { get; set; }

        [DataMember]
        public int PedidoAdn { get; set; }

        [DataMember]
        public string NumOrdenCompra { get; set; }

        [DataMember]
        public VoucherInformation OrderVoucherInformation { get; set; }

        [DataMember]
        public bool SolicitarHuella { get; set; }

        [DataMember]
        public int StatusID { get; set; }

        [DataMember]
        public List<TarjetaCredito> TarjetaTDCompra { get; set; }

        [DataMember]
        public List<Pedido> DetallesPedido { get; set; }

        [DataMember]
        public InformacionFactura InformacionFactura { get; set; }

        [DataMember]
        public int Tienda { get; set; }

        [DataMember]
        public string TipoValidacionPedido { get; set; }

        [DataMember]
        public byte TipoVenta { get; set; }

        [DataMember]
        public bool EsConTarjeta { get; set; }

      
    }
}