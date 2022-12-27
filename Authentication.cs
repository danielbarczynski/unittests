public class Authentication 
{
    private readonly IUser _user;
    public Authentication(IUser user)
    {
        _user = user;
    }

    public bool LoginUser(string username, string password) => _user.IsAuthenticated(username, password); 
}