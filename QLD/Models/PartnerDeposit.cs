//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnerDeposit
    {
        public long PartnerDepositId { get; set; }
        public Nullable<long> PartnerId { get; set; }
        public Nullable<decimal> Money { get; set; }
        public Nullable<System.DateTime> Day { get; set; }
        public string Note { get; set; }
    
        public virtual Partner Partner { get; set; }
    }
}