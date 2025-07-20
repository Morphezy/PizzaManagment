using Application.Dto;
using Domain.Models;

namespace Application.Mappers;

public static class ToNewCustomerDtoMapper
{
    public static NewCustomerDto ToNewCustomerDto(this Customer customer)
    {
        return new NewCustomerDto{ Email = customer.Email};
    }
}