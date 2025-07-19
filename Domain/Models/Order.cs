namespace Domain.Models;

public class Order
{
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
}