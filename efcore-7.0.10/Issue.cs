namespace efcore_7._0._10;

public class Issue
{
    public Issue(int id)
    {
        Id = id;
    }

    public int Id { get; }

    public string? Name { get; set; }

    public double? Weight { get; set; }

    public bool IsDeleted { get; set; }
}