namespace ASPNETCore6CustomAttribute.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class MyLogAttribute : Attribute, IFilterFactory, IFilterMetadata
    //public class MyAttribute : ActionFilterAttribute
    {
        public bool IsReusable => false;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetRequiredService<MyLogActionFilter>();
        }
    }
}
