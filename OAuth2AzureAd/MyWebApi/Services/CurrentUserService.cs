using System.Security.Claims;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor) => _httpContextAccessor = httpContextAccessor;

    public bool IsAuthenticated() => _httpContextAccessor.HttpContext?.User.Identity?.IsAuthenticated ?? false;

    public string Id
        => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier)
           ?? string.Empty;

    public string UserName
        => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name)
           ?? string.Empty;

    public string Email
        => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Name)
           ?? string.Empty;

    public string FullName
        => _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.GivenName)
           ?? string.Empty;
}