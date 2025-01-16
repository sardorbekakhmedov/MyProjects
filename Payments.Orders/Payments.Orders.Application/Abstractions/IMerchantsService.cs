using Payments.Orders.Application.Models.Merchants;

namespace Payments.Orders.Application.Abstractions;

public interface IMerchantsService
{
    Task<MerchantDto> Create(MerchantDto merchant);
}