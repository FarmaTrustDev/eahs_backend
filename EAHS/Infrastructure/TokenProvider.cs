using Microsoft.AspNetCore.Http;
using System.Linq;

namespace EAHS.Infrastructure
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetAccessToken()
        {
            HttpContext httpContext = _httpContextAccessor.HttpContext;
            string accessToken = string.Empty;

            if (HasAuthorizationHeader(httpContext))
            {
                var headers = httpContext.Request.Headers;
                var authHeader = headers["Authorization"];

                if (!string.IsNullOrEmpty(authHeader))
                {
                    string[] authData = authHeader[0].Split(' ');

                    if (authData.Count() > 1)
                    {
                        accessToken = authData[1];
                    }
                }
            }

            return accessToken;
        }

        private bool HasAuthorizationHeader(HttpContext httpContext)
        {
            bool hasAuthorizationHeaderExists = false;
            var headers = httpContext.Request.Headers;
            var authHeader = headers["Authorization"];

            if (!string.IsNullOrEmpty(authHeader))
            {
                hasAuthorizationHeaderExists = true;
            }

            return hasAuthorizationHeaderExists;
        }
    }
}
