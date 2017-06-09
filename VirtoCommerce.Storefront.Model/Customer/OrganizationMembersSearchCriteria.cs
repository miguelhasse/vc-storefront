using System.Collections.Specialized;
using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model.Customer
{
    public class OrganizationMembersSearchCriteria : PagedSearchCriteria
    {
        private static int _defaultPageSize = 20;

        public static int DefaultPageSize
        {
            get { return _defaultPageSize; }
            set { _defaultPageSize = value; }
        }

        public OrganizationMembersSearchCriteria() : base(new NameValueCollection(), _defaultPageSize)
        {
        }
        public OrganizationMembersSearchCriteria(NameValueCollection queryString) : base(queryString, DefaultPageSize)
        {
        }

        public string MemberId { get; set; }
        public string Sort { get; set; }
    }
}
