public interface ICurrentUserService
{
    bool IsAuthenticated();
    public string Id { get; }
    public string UserName { get; }
    public string Email { get; }
    public string FullName { get; }

    //rest of needed claims can be added by your need.
}