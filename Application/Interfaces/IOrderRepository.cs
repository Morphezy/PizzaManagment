using Domain.Models;

namespace Application.Interfaces;

public interface IOrderRepository
{
    public  Task<Order> CreateOrder(int id);
}