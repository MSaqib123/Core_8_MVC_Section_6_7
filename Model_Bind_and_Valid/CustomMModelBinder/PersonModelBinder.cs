using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CSharp.RuntimeBinder;
using Model_Bind_and_Valid.Models;

namespace Model_Bind_and_Valid.CustomMModelBinder
{
    public class PersonModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            Custm_ModelBinder p = new Custm_ModelBinder();
            //___ FirstName ___
            if (bindingContext.ValueProvider.GetValue("FirstName").Length > 0)
            {
                p.PersonName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;
                if (bindingContext.ValueProvider.GetValue("FirstName").Length > 0)
                {
                    p.PersonName += " " + bindingContext.ValueProvider.GetValue("FirstName").FirstValue;
                }
            }
            //email
            if (bindingContext.ValueProvider.GetValue("Email").Length > 0)
                p.Email = bindingContext.ValueProvider.GetValue("Email").FirstValue;

            //Phone
            if (bindingContext.ValueProvider.GetValue("Phone").Length > 0)
                p.Phone = bindingContext.ValueProvider.GetValue("Phone").FirstValue;

            //SirName
            if (bindingContext.ValueProvider.GetValue("SirName").Length > 0)
                p.SirName = bindingContext.ValueProvider.GetValue("SirName").FirstValue;

            //Price
            if (bindingContext.ValueProvider.GetValue("Price").Length > 0)
                p.Price= bindingContext.ValueProvider.GetValue("Price").FirstValue;

            bindingContext.Result = ModelBindingResult.Success(p);
            return Task.CompletedTask;
        }
    }
}
