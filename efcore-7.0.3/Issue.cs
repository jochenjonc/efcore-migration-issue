namespace efcore_7._0._3;

public class Issue
{
    public Issue(int id)
    {
        Id = id;
    }

    public int Id { get; }

    public string? Name { get; set; }

    public double? Weight { get; set; }
}