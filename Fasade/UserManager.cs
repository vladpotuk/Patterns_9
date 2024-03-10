using System;
using System.Collections.Generic;

public class UserManager : IUserManager
{
    private Dictionary<string, User> _users;

    public UserManager()
    {
        _users = new Dictionary<string, User>();
    }

    public void AddUser(User user)
    {
        _users[user.Username] = user;
        Console.WriteLine($"User {user.Username} added.");
    }

    public void DeleteUser(string username)
    {
        _users.Remove(username);
        Console.WriteLine($"User {username} deleted.");
    }

    public User GetUser(string username)
    {
        if (_users.ContainsKey(username))
            return _users[username];
        else
            return null;
    }

    public void UpdateUser(User user)
    {
        _users[user.Username] = user;
        Console.WriteLine($"User {user.Username} updated.");
    }
}
