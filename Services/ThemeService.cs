using Microsoft.AspNetCore.Http;

namespace sharp_tasks.Services;

public class ThemeService : IThemeProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private const string DefaultTheme = "light";
    private const string CookieName = "theme";

    public ThemeService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string GetTheme()
    {
        var httpContext = _httpContextAccessor.HttpContext;
        if (httpContext?.Request.Cookies.TryGetValue(CookieName, out var cookieTheme) == true)
        {
            return cookieTheme;
        }
        return DefaultTheme;
    }
}