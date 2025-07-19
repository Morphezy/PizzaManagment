namespace Domain.Models;

public class Pizza
{
    public Guid Id { get; set; }
    public string CustomerName { get; set; }
    public float Diameter { get; set; }
    public bool IsSliced { get; set; }
    public bool Pineapple { get; set; }
    public bool Bacon { get; set; }
    public bool Cheese { get; set; }
    public bool Sausage { get; set; }
    public bool Tomato { get; set; }
    public bool Mushroom { get; set; }
    public bool Onion { get; set; }
    public bool Beef { get; set; }
    public bool Chicken { get; set; }
    public bool Egg { get; set; }
    public DateTime OrderedAt { get; set; }
}