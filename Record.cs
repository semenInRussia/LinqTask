namespace LinqTask;

class Record(User author, string message)
{
  public User Author { get; set; } = author;
  public string Message { get; set; } = message;
}
