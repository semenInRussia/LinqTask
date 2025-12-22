namespace LinqTask;

class BusinessLogic
{
  readonly private List<User> users = [];
  readonly private List<Record> records = [];

  public List<User> GetAllUsers() => users;

  public BusinessLogic()
  {
    var user2 = new User(2, "Agnia", "Bartoo");
    users.Add(user2);

    var user1 = new User(1, "Semen", "Khramtsov");
    users.Add(user1);

    var user3 = new User(3, "Ann", "Dark");
    users.Add(user3);

    var user4 = new User(4, "Robert", "Martin");
    users.Add(user4);

    var user5 = new User(5, "Kent", "Beck");
    users.Add(user5);

    var user6 = new User(6, "Kent", "Khramtsov");
    users.Add(user6);

    foreach (var user in users)
    {
      records.Add(new(user, $"Hi, my name is {user.Name} {user.Surname}"));
    }
  }

  public List<User> GetUsersBySurname(string surname)
  {
    return (from u in users where u.Surname == surname select u).ToList();
  }

  public User GetUserByID(int id)
  {
    return (from u in users where u.ID == id select u).Single();
  }

  public List<User> GetUsersBySubstring(string substring)
  {
    return (from u in users where u.Name.Contains(substring) || u.Surname.Contains(substring) select u).ToList();
  }

  public List<string> GetAllUniqueNames()
  {
    return (from u in users select u.Name).Distinct().ToList();
  }

  public Dictionary<int, User> GetUsersDictionary()
  {
    return users.ToDictionary(u => u.ID, u => u);
  }

  public int GetMaxID()
  {
    return users.Max(u => u.ID);
  }

  public List<User> GetOrderedUsers()
  {
    return (from u in users orderby u.ID select u).ToList();
  }

  public List<User> GetDescendingOrderedUsers()
  {
    return (from u in users orderby u.ID descending select u).ToList();
  }

  public List<User> GetReversedUsers()
  {
    return users.Reverse<User>().ToList();
  }

  public List<User> GetUsersPage(int pageSize, int i)
  {
    return users.Skip(pageSize * i).Take(pageSize).ToList();
  }
}
