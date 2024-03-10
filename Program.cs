using System;

class Program
{
    static void Main(string[] args)
    {
        
        IUserManager userManager = new UserManagerProxy(isAdmin: true);

       
        User newUser = new User { Username = "user1", Password = "password1", Email = "user1@example.com", FullName = "User One", IsActive = true };
        userManager.AddUser(newUser);

        
        User existingUser = userManager.GetUser("user1");
        if (existingUser != null)
        {
            existingUser.IsActive = false;
            userManager.UpdateUser(existingUser);
        }

        
        userManager.DeleteUser("user1");

        
        IUserManager regularUserManager = new UserManagerProxy(isAdmin: false);
        User regularUser = new User { Username = "user2", Password = "password2", Email = "user2@example.com", FullName = "User Two", IsActive = true };
        regularUserManager.AddUser(regularUser);

        Console.ReadKey();
    }
}
