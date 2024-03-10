public interface IUserManager
{
    User GetUser(string username);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(string username);
}
