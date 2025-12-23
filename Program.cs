using LinqTask;

var bl = new BusinessLogic();

Console.WriteLine("All users:\n---");
foreach (var user in bl.GetAllUsers())
{
  Console.WriteLine($"- {user}");
}
Console.WriteLine("\n");

Console.WriteLine("Users with surname Khramtsov:\n---");
foreach (var user in bl.GetUsersBySurname("Khramtsov"))
{
  Console.WriteLine($"- {user}");
}
Console.WriteLine("\n");

Console.WriteLine("User with ID 2:\n---");
Console.WriteLine(bl.GetUserByID(2));
Console.WriteLine("\n");

Console.WriteLine("Users with substring 'A' in name:\n---");
foreach (var user in bl.GetUsersBySubstring("A"))
{
  Console.WriteLine($"- {user}");
}
Console.WriteLine("\n");

Console.WriteLine("All unique names:\n---");
foreach (var name in bl.GetAllUniqueNames())
{
  Console.WriteLine($"- {name}");
}
Console.WriteLine("\n");

Console.WriteLine("Dictionary of all users:\n---");
foreach (var idName in bl.GetUsersDictionary())
{
  Console.WriteLine($"- {idName.Key}: {idName.Value}");
}
Console.WriteLine("\n");

Console.WriteLine($"Max ID: {bl.GetMaxID()}");

Console.WriteLine("Ordered users:\n---");
foreach (var user in bl.GetOrderedUsers())
{
  Console.WriteLine($"- {user}");
}
Console.WriteLine("\n");

Console.WriteLine("Descending ordered users:\n---");
foreach (var user in bl.GetDescendingOrderedUsers())
{
  Console.WriteLine($"- {user}");
}
Console.WriteLine("\n");

Console.WriteLine("Users on pages:\n---");
for (int i = 1; i <= 3; i++)
{
  Console.WriteLine($"Page {i}:");
  foreach (var user in bl.GetUsersPage(2, i))
  {
    Console.WriteLine($"- {user}");
  }
}
