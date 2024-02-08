
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework; // Replace with your actual DataAccess namespace
using Entities.Concrete;
using System;


    // Assuming you have an EntityFramework implementation of IUserDal
    IUserDal userDal = new EfUserDal(); // Replace with your actual implementation

    UserManager userManager = new UserManager(userDal);

    // Adding users to the database
    AddSampleUsers(userManager);

    // Retrieve and display all users
    //DisplayAllUsers(userManager);

    // Retrieve and display users with a specific username
    //DisplayUsersByName(userManager, "JohnDoe");

    static void AddSampleUsers(UserManager userManager)
    {
        User user1 = new User { Id = 1, Name = "JohnDoe", Email = "john.doe@example.com", Password = "password1" };
        User user2 = new User { Id = 2, Name = "JaneDoe", Email = "jane.doe@example.com", Password = "password2" };

        userManager.AddUser(user1);
        userManager.AddUser(user2);
    }

    //static void DisplayAllUsers(UserManager userManager)
    //{
    //    Console.WriteLine("All Users:");
    //    var allUsers = userManager.GetAll();
    //    foreach (var user in allUsers)
    //    {
    //        Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
    //    }
    //    Console.WriteLine();
    //}

    //static void DisplayUsersByName(UserManager userManager, string userName)
    //{
    //    Console.WriteLine($"Users with Name '{userName}':");
    //    var usersByName = userManager.GetByUserName(userName);
    //    foreach (var user in usersByName)
    //    {
    //        Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
    //    }
    //    Console.WriteLine();
    //}


