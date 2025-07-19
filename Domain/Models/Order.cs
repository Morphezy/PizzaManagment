namespace Domain.Models;

public class Order
{
    public int Id { get; set; }
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
}