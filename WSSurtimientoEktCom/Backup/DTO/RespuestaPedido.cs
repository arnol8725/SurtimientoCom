using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    public class RespuestaPedido: Respuesta
    {
        public long Pedido { get; set; }
        public string cadenaVoucher { get; set; }
    }
}