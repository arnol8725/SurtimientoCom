using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Elektra.Servicios.SurtimientoEktCom.DTO;
using Elektra.Negocio.EktCom;
using Elektra.Services.Loader;
using System.ServiceModel.Web;
using System.Web;
using System.Web.UI;

namespace Elektra.Servicios.SurtimientoEktCom

    
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class WSSurtimientoEktCom : IWSSurtimientoEktCom
    {

        public void OpcionesPreflight()
        {

            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "POST,OPTIONS");
            WebOperationContext.Current.OutgoingResponse.Headers.Add("Access-Control-Allow-Headers", "Content-Type,Accept");
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public WSSurtimientoEktCom()
        {
            AssemblyResolve.InitResolveEvent();
        }

        public OrdenCompra InfoOrdenCompraEktCom(string folio,string empleado, string estacion)
        {
            OrdenCompra orden = new OrdenCompra();
            try
            {
                if (!string.IsNullOrEmpty(folio))
                {
                    CtrlEktCom negocioEktCom = new CtrlEktCom();
                    orden = negocioEktCom.obtenerInfoOrdenCompra<OrdenCompra>(folio,empleado,estacion);
                }
                else
                {
                    orden.EsError = true;
                    orden.MensajeUsuario = "Favor de validar datos";
                    orden.MensajeTecnico = "Favor de validar datos";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Exepcion al obtener la orden de compra :" + ex.Message, "log");
                orden.EsError = true;
                orden.MensajeUsuario = "No se obtuvieron datos de la orden de compra";
                orden.MensajeTecnico = "Exepcion en al obtener la orden de compra: " + ex.Message;
            }
            return orden;
        }


        public RespuestaValidacion ValidarNumeroTarjeta(string cadenaOriginal, string cadenaCapturada)
        {
            RespuestaValidacion respuesta = new RespuestaValidacion();
            try
            {
                if (!string.IsNullOrEmpty(cadenaCapturada) && !string.IsNullOrEmpty(cadenaOriginal))
                {
                    CtrlEktCom negocioEktCom = new CtrlEktCom();
                    respuesta.EsValido = negocioEktCom.ValidaNumeroDeTarjeta(cadenaOriginal, cadenaCapturada);
                    if (respuesta != null && !respuesta.EsValido)
                    {
                        respuesta.MensajeUsuario = "El numero de tarjeta no es valido.";
                        respuesta.MensajeTecnico = "El numero de tarjeta no es valido.";
                    }
                }
                else
                {
                    respuesta.EsValido = false;
                    respuesta.MensajeUsuario = "El numero de tarjeta no es valido.";
                    respuesta.MensajeTecnico = "El numero de tarjeta no es valido.";
                }
            }
            catch (Exception ex)
            {
                respuesta.EsValido = false;
                respuesta.MensajeUsuario = "El numero de tarjeta no es valido.";
                respuesta.MensajeTecnico = "El numero de tarjeta no es valido." + ex.Message;
                System.Diagnostics.Trace.WriteLine("Exepcion al ValidarNumeroTarjeta :" + ex.Message, "log");
            }
            return respuesta;
        }


        public RespuestaPedido GenerarPedido(string folio, string empleado, string estacionTrabajo, string ipWS)
        {
            RespuestaPedido respuesta = new RespuestaPedido();
            try
            {
                CtrlEktCom negocioEktCom = new CtrlEktCom();
                var resp = negocioEktCom.GenerarPedidoSurtimientoEPOS(folio, empleado, estacionTrabajo, ipWS);
                if (resp != null)
                {
                    if (resp.EsError)
                    {
                        respuesta.EsError = resp.EsError;
                        respuesta.MensajeTecnico = resp.MensajeTecnico;
                        respuesta.MensajeUsuario = "Error al generar pedido.";
                    }
                    else
                        respuesta.Pedido = resp.NoPedido;
                }
            }
            catch (Exception ex)
            {
                respuesta.EsError = true;
                respuesta.MensajeTecnico = "Error al generar pedido" + ex.Message;
                respuesta.MensajeUsuario = "Error al generar pedido.";
            }
            return respuesta;
        }
       
        public RespuestaPedido GenerarPedidoNuevo(string folio, string empleado, string estacionTrabajo, string ipWS)
        {
            RespuestaPedido respuesta = new RespuestaPedido();
            try
            {
                //string ip = HttpContext.Current.Request.UserHostAddress;

              //  var IpUser = System.ServiceModel.OperationContext.Current.Channel.RemoteAddress.Uri.Host;
               
          
                CtrlEktCom negocioEktCom = new CtrlEktCom();
                var resp = negocioEktCom.GrabarPresupPedidoSurtContado(folio, empleado, estacionTrabajo,673, ipWS);
                
                if (resp != null)
                {
                    if (resp.EsError)
                    {
                        respuesta.EsError = resp.EsError;
                        respuesta.MensajeTecnico = resp.MensajeTecnico;
                        respuesta.MensajeUsuario = "Error al generar pedido.";
                    }
                    else
                    {
                        respuesta.cadenaVoucher = resp.XMLPagare;
                        respuesta.Pedido = resp.NoPedido;
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta.EsError = true;
                respuesta.MensajeTecnico = "Error al generar pedido" + ex.Message;
                respuesta.MensajeUsuario = "Error al generar pedido.";
            }
            return respuesta;
        }
       
    }
}
