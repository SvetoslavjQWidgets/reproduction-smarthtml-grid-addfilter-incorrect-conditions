namespace BlazorProject1.Client
{
  public class Entity
  {
    public Guid Id { get; set; }
  }

  public class ClassName : Entity
  {
    public string Name { get; set; }
    public string Value { get; set; }
    public string Description { get; set; }
    public bool BoolValue { get; set; }
  }
}
