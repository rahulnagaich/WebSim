using Microsoft.AspNetCore.Http;
using WebSim.Persistence.Core;

namespace WebSim.Persistence
{
    public class HttpUnitOfWork : UnitOfWork
    {
        public HttpUnitOfWork(DatabaseService context, IHttpContextAccessor httpAccessor) : base(context)
        {
            context.CurrentUserId = httpAccessor.HttpContext?.User.FindFirst(ClaimConstants.Subject)?.Value?.Trim();
        }
    }
}