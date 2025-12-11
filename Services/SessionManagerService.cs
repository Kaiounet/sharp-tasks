using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace sharp_tasks.Services;

public class SessionManagerService : ISessionManagerService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SessionManagerService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void Add(string key, Object value)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        httpContext.Session.SetString(key, JsonSerializer.Serialize(value));
    }

    public T Get<T>(string key)
    {
        var httpContext = _httpContextAccessor.HttpContext;
        return JsonSerializer.Deserialize<T>(httpContext.Session.GetString(key) ?? "[]");
    }
}
