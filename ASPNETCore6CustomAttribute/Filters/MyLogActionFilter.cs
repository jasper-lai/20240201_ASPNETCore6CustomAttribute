namespace ASPNETCore6CustomAttribute.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;

    public class MyLogActionFilter : IActionFilter
    {
        private readonly ILogger<MyLogActionFilter> _logger;

        public MyLogActionFilter(ILogger<MyLogActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Action is executing.");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("Action executed.");
        }
    }
}
