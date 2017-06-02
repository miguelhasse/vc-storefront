using System.Web;
using VirtoCommerce.Storefront.Model;
using VirtoCommerce.Storefront.Model.Common;
using VirtoCommerce.Storefront.Model.Security;

namespace VirtoCommerce.LiquidThemeEngine.Binders
{
    public class RegisterModelBinder : BaseModelBinder<Register>
    {
        protected override void ComplementModel(Register model, HttpRequestBase request)
        {
            model.AccountType = EnumUtility.SafeParse(request["accountType"], AccountType.Personal);
            model.CompanyName = request["customer[company_name]"];
            model.FirstName = request["customer[first_name]"];
            model.LastName = request["customer[last_name]"];
            model.Email = request["customer[email]"];
            model.UserName = request["customer[user_name]"];
            model.Password = request["customer[password]"];
        }
    }
}
