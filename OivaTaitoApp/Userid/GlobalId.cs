using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
namespace OivaTaitoApp.Userid
{
    public class GlobalId
    {
        private readonly IHttpContextAccessor _accessor;

        public GlobalId(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string GetGlobalId()
        {
            if (_accessor != null && _accessor.HttpContext != null && _accessor.HttpContext.User != null)
                return
                    _accessor.HttpContext.User
                    .FindFirstValue(ClaimTypes.NameIdentifier);
            else
                return null;
        }
    }
}
