
using JWT_Sample;
using Microsoft.Data.SqlClient;

Console.WriteLine("Enter user name: ");
string userName = Console.ReadLine();
Console.WriteLine("Enter user password: ");
string userPassword = Console.ReadLine();

JwtUserService userService = new JwtUserService();
Console.WriteLine(userService.Authenticate(userName, userPassword));

Console.ReadKey();


