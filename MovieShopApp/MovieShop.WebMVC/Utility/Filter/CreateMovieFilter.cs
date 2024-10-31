using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MovieShop.WebMVC.Utility.Filter
{
    public class CreateMovieFilter : IAsyncActionFilter
    {
        private readonly ILogger _logger;
        public CreateMovieFilter(ILogger loggerFactory)
        {
            _logger = loggerFactory;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
            var resultContext = await next();
            _logger.LogInformation(resultContext.ToString());
        }
    }
}
