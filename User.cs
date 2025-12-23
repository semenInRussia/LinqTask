namespace LinqTask;

class User(int id, string name, string surname)
{
  public int ID { get; } = id;
  public string Name { get; set; } = name;
  public string Surname { get; set; } = surname;

  public override string ToString()
  {
    return string.Format("ID={0}: {1} {2}", ID, Name, Surname);
  }
}
