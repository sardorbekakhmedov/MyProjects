using Payments.Orders.Application.Models.Carts;

namespace Payments.Orders.Application.Abstractions;

public interface ICartsService
{
    Task<CartDto> Create(CartDto cart);
}