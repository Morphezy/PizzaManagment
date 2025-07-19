using Microsoft.AspNetCore.Identity;

namespace Domain.Models;

public class Customer : IdentityUser
{
    public List<Order> Orders { get; set; }
}