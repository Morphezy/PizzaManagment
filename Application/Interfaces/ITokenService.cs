using Domain.Models;

namespace Application.Interfaces;

public interface ITokenService
{
    Task<string> GenerateToken(Customer customer);
}