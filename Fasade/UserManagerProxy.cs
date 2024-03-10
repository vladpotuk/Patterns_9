using System;

public class UserManagerProxy : IUserManager
{
    private bool _isAdmin;
    private UserManager _userManager;

    public UserManagerProxy(bool isAdmin)
    {
        _isAdmin = isAdmin;
        _userManager = new UserManager();
    }

    public void AddUser(User user)
    {
        if (_isAdmin)
        {
            _userManager.AddUser(user);
        }
        else
        {
            Console.WriteLine("Access denied. Only admin can add users.");
        }
    }

    public void DeleteUser(string username)
    {
        if (_isAdmin)
        {
            _userManager.DeleteUser(username);
        }
        else
        {
            Console.WriteLine("Access denied. Only admin can delete users.");
        }
    }

    public User GetUser(string username)
    {
        return _userManager.GetUser(username);
    }

    public void UpdateUser(User user)
    {
        if (_isAdmin)
        {
            _userManager.UpdateUser(user);
        }
        else
        {
            Console.WriteLine("Access denied. Only admin can update users.");
        }
    }
}
