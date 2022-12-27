public interface IUser 
{
    bool IsAuthenticated(string username, string password);
}