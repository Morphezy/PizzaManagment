namespace Domain.Models;

public class PendingOrder
{
    public int Id { get; set; }
    public Order Order { get; set; }
}