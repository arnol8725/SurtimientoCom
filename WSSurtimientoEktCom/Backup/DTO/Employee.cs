using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    public class Employee
    {
        [DataMember]
        public string CompanyCode { get; set; }

        [DataMember]
        public int Number { get; set; }
    }
}