namespace Payments.Orders.Domain.Exceptions;

public class DuplicateEntityException(string? message = null) : Exception(message)
{
    
}