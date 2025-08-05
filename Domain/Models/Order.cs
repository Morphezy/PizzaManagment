using CSharpFunctionalExtensions;

namespace Domain.Models;

public class Order
{
    private Order(int id, List<Pizza> pizzas, Customer customer )
    {
        Id = id;
        Pizzas = pizzas;
        Customer = customer;
    }
    public int Id { get; set; }
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }

    public static Result<Order> CreateOrder( int id, List<Pizza> pizzas, Customer customer)
    {
        if(pizzas.Count == 0 ||customer == null)
            return Result.Failure<Order>("Order is empty");
        return Result.Success<Order>(new Order(id, pizzas, customer));
    }
}