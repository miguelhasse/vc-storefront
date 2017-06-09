using System;
using System.Collections.Generic;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model.Customer
{
    /// <summary>
    /// Represent member information structure 
    /// </summary>
    public class MemberInfo : Entity
    {
        public MemberInfo()
        {
            Addresses = new List<Address>();
            Phones = new List<string>();
            Emails = new List<string>();
        }

        public string Name { get; set; }
        public string MemberType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<string> Phones { get; set; }
        public ICollection<string> Emails { get; set; }
    }
}
