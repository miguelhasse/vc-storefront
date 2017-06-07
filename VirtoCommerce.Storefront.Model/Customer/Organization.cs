using System.Collections.Generic;

namespace VirtoCommerce.Storefront.Model.Customer
{
    public class Organization
    {
        public Organization()
        {
            Addresses = new List<Address>();
            DynamicProperties = new List<DynamicProperty>();
        }

        public string Id { get; set; }

        public string Name { get; set; }
        public string MemberType { get; set; }

        public string Description { get; set; }
        public string BusinessCategory { get; set; }
        public string OwnerId { get; set; }
        public string ParentId { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public ICollection<DynamicProperty> DynamicProperties { get; set; }
    }
}
