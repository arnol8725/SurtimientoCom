using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Elektra.Servicios.SurtimientoEktCom.DTO
{
    [DataContract]
    public class VoucherInformation
    {
        [DataMember]
        public string Acquirer { get; set; }

        [DataMember]
        public string ECICode { get; set; }

        [DataMember]
        public string ISOCode { get; set; }

        [DataMember]
        public int MembershipNumber { get; set; }

        [DataMember]
        public string PAZAuthorizationNumber { get; set; }

        [DataMember]
        public string PAZReferenceNumber { get; set; }

        [DataMember]
        public int StoreNumber { get; set; }

        [DataMember]
        public decimal TransactionAmount { get; set; }

        [DataMember]
        public string TransactionCardExpirationDate { get; set; }

        [DataMember]
        public string TransactionCardIssuingBank { get; set; }

        [DataMember]
        public string TransactionCardNumber { get; set; }

        [DataMember]
        public string TransactionDate { get; set; }

        [DataMember]
        public string TransactionMaskedCardNumber { get; set; }

        [DataMember]
        public string TransactionTime { get; set; }
    }
}