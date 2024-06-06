using System.ComponentModel.DataAnnotations;

namespace Models;

public class Opportunity
{
    [Key]
    public int Id { get; set; }

    public string Description { get; set; }

    public DateTime DeliveryDate { get; set; }

    public string SurgeLevel { get; set; }

    public int HoursQuantity { get; set; }

    public long ErrorsQuantity { get; set; }

    public long LearningLevel { get; set; }

    public long HoursOfSleep { get; set; }

    public long HoursOff { get; set; }

    public Opportunity() { }

    public Opportunity(int id, string description, DateTime deliveryDate, string surgeLevel, int hoursQuantity, long errorsQuantity, long learningLevel, long hoursOfSleep, long hoursOff)
    {
        Id = id;
        Description = description;
        DeliveryDate = deliveryDate;
        SurgeLevel = surgeLevel;
        HoursQuantity = hoursQuantity;
        ErrorsQuantity = errorsQuantity;
        LearningLevel = learningLevel;
        HoursOfSleep = hoursOfSleep;
        HoursOff = hoursOff;
    }
}
