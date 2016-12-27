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
    
    public partial class Contract
    {
        public Contract()
        {
            this.ContracImages = new HashSet<ContracImage>();
            this.GuidesPrices = new HashSet<GuidesPrice>();
            this.InsurancePrices = new HashSet<InsurancePrice>();
        }
    
        public long ContractId { get; set; }
        public string ServiceId { get; set; }
        public Nullable<int> ContractTypeId { get; set; }
        public Nullable<long> ProviderId { get; set; }
        public Nullable<long> PartnerId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ContractLocation { get; set; }
        public Nullable<System.DateTime> ContractTime { get; set; }
        public Nullable<System.DateTime> FromDay { get; set; }
        public Nullable<System.DateTime> ToDay { get; set; }
        public Nullable<decimal> DebtTerm { get; set; }
        public Nullable<decimal> DebtTermMax { get; set; }
        public string Files { get; set; }
        public string Files1 { get; set; }
        public string Contents { get; set; }
        public string Description { get; set; }
        public Nullable<int> Status { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDay { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDay { get; set; }
    
        public virtual ICollection<ContracImage> ContracImages { get; set; }
        public virtual ContractType ContractType { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ICollection<GuidesPrice> GuidesPrices { get; set; }
        public virtual ICollection<InsurancePrice> InsurancePrices { get; set; }
    }
}
