using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Elektra.Servicios.SurtimientoEktCom.DTO;
using System.ServiceModel.Web;

namespace Elektra.Servicios.SurtimientoEktCom
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWSSurtimientoEktCom
    {
        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void OpcionesPreflight();

        [OperationContract]
        string GetData(int value);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/InfoOrdenCompraEktCom?folio={folio}&empleado={empleado}&estacion={estacion}")]
        [OperationContract]
        OrdenCompra InfoOrdenCompraEktCom(string folio, string empleado, string estacion);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/ValidarNumeroTarjeta", BodyStyle = WebMessageBodyStyle.Wrapped)]
        [OperationContract]
        RespuestaValidacion ValidarNumeroTarjeta(string cadenaOriginal, string cadenaCapturada);

        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedido", BodyStyle = WebMessageBodyStyle.Wrapped)]
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedido?folio={folio}&empleado={empleado}&estacionTrabajo={estacionTrabajo}&ipWS={ipWS}")]
        [OperationContract]
        RespuestaPedido GenerarPedido(string folio, string empleado, string estacionTrabajo, string ipWS);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedidoNuevo?folio={folio}&empleado={empleado}&estacionTrabajo={estacionTrabajo}&ipWS={ipWS}")]
        //[WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GenerarPedido?folio={folio}&empleado={empleado}&estacionTrabajo={estacionTrabajo}&ipWS={ipWS}")]
        [OperationContract]
        RespuestaPedido GenerarPedidoNuevo(string folio, string empleado, string estacionTrabajo, string ipWS);

        

        // TODO: Add your service operations here
    }


    
}
