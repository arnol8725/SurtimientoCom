using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class InformacionCliente
    {
        [DataMember]
        public string CteApellidoMaterno { get; set; }
        [DataMember]
        public string CteApellidoPaterno { get; set; }
        [DataMember]
        public string CteDirCalle { get; set; }
        [DataMember]
        public int CteDirCodPostal { get; set; }
        [DataMember]
        public string CteDirColonia { get; set; }
        [DataMember]
        public string CteDirNoExt { get; set; }
        [DataMember]
        public string CteDirNoInt { get; set; }
        [DataMember]
        public string CteDirTelefono { get; set; }
        [DataMember]
        public int CteEdoCivil { get; set; }
        [DataMember]
        public DateTime CteFecNac { get; set; }
        [DataMember]
        public string CteFisMor { get; set; }
        [DataMember]
        public string CteNombre { get; set; }
        [DataMember]
        public string CteRFC { get; set; }
        [DataMember]
        public int CteSexo { get; set; }
        [DataMember]
        public Employee EmployeeInfo { get; set; }
    }
}