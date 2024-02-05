using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Model_Bind_and_Valid.Models;

namespace Model_Bind_and_Valid.CustomMModelBinder
{
    public class globalPersonModelBinder:IModelBinderProvider
    {
        //Add this class in Program file as services in Controller
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(Custm_ModelBinder))
            {
                return new BinderTypeModelBinder(typeof(PersonModelBinder));
            }
            return null;
        }
    }
}
