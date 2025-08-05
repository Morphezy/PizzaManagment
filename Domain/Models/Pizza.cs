namespace Domain.Models;

public class Pizza
{
    
    
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string CustomerName { get; private  set; }
    public bool IsSliced { get; private set; }
    public bool Pineapple { get; private set; }
    public bool Bacon { get; private set; }
    public bool Cheese { get; private set; }
    public bool Sausage { get; private set; }
    public bool Tomato { get; private set; }
    public bool Mushroom{ get; private set; }
    public bool Onion { get; private set; }
    public bool Beef { get; private set; }
    public bool Chicken { get; private set; }
    public DateTime OrderedAt { get; private set; }
    public int OrderId{ get; private set; }
    public Order Order{ get; private set; }
    
    private Pizza(int id,  bool isSliced,bool pineapple ,bool bacon,bool cheese, bool sausage, bool tomato, bool mushroom,
        bool onion, bool beef, bool chicken, Customer customer)
    {
        Id = id;
        CustomerName = customer.Email;
        IsSliced = false;
        Pineapple = false;
        Bacon = false;
        Cheese = false;
        Sausage = false;
        Tomato = false;
    }
}