namespace Models;

public class Doubt
{
    public int Id { get; set; }
    public string Description { get; set; }
    public DateTime DoubtDate { get; set; }

    public Doubt() { }

    public Doubt(int id, string description, DateTime doubtDate)
    {
        Id = id;
        Description = description;
        DoubtDate = doubtDate;
    }

}
