using Microsoft.AspNetCore.Http;

namespace AppTea.Infrastructure
{
    public static class UnExtenssions
    {
        public static string PathAndQuery(this HttpRequest request)
            => request.QueryString.HasValue
            ? $"{request.Path}{request.QueryString}"
            : request.Path.ToString();
    }
}

