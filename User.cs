public class User : IUser
{
    public bool IsAuthenticated(string username, string password)
    {
        if (username == "user1" && password == "p4ssw0rd")
            return true;
        
        return false;
    }
}