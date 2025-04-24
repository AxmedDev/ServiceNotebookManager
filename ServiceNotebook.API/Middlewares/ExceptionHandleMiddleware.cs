namespace ServiceNotebook.API.Middlewares
{
    public class ExceptionHandleMiddleware
    {
        RequestDelegate next;
        private ILogger<ExceptionHandleMiddleware> logger;
        public ExceptionHandleMiddleware(RequestDelegate next, ILogger<ExceptionHandleMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                
                await next(context);
            }
            catch (Exception ex)
            {
              
                var endpoint = context.GetEndpoint();
                var routeValues = context.Request.RouteValues;

                string controller = routeValues["controller"]?.ToString() ?? "Unknown";
                string action = routeValues["action"]?.ToString() ?? "Unknown";


                string? user = context.User?.Identity?.IsAuthenticated == true
                    ? context.User.Identity.Name
                    : "Anonymous";


                string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

                string method = context.Request.Method;
                string path = context.Request.Path;


                logger.LogError(ex,
                    "❌ Error occurred!\nTimestamp: {Timestamp}\nUser: {User}\nController: {Controller}\nAction: {Action}\nMethod: {Method}\nPath: {Path}",
                    timestamp, user, controller, action, method, path);

                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("There were many problems in the service");

            }
        }
    }
}
