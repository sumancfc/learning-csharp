namespace learningCSharp.Projects;
// Login Authentication:
//
// Simulate a simple login system. Ask the user for a username and password. If the username is "admin" and
// the password is "password123", display "Login successful." Otherwise, display "Login failed."

public class LoginSystem
{
    public void authenticationSystem()
    {
        Console.Write("Enter the username: ");
        string username = Console.ReadLine();
        Console.Write("Enter the password: ");
        string password = Console.ReadLine();

        if (username == "admin" && password == "password123")
        {
            Console.WriteLine("Login Successful.");
        }
        else
        {
            Console.WriteLine("Login Failed.");
        }
    }
}