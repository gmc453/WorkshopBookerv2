namespace WorkshopBooker.Emergency.Domain.Entities;

public class EmergencyRequest
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public DateTime CreatedAt { get; set; }

    public EmergencyRequest() { }

    public EmergencyRequest(Guid userId, string description)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        Description = description;
        Status = "Pending";
        CreatedAt = DateTime.UtcNow;
    }
}
