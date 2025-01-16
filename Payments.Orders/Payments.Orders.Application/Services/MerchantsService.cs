using Payments.Orders.Application.Abstractions;
using Payments.Orders.Application.Models.Merchants;
using Payments.Orders.Domain;
using Payments.Orders.Domain.Entities;

namespace Payments.Orders.Application.Services;

public class MerchantsService(OrdersDbContext context) : IMerchantsService
{
    public async Task<MerchantDto> Create(MerchantDto merchant)
    {
        var entity = new MerchantEntity
        {
            Name = merchant.Name,
            Phone = merchant.Phone,
            WebSite = merchant.WebSite
        };

        var result = await context.Merchants.AddAsync(entity);
        var resultEntity = result.Entity;
        
        await context.SaveChangesAsync();

        return new MerchantDto
        {
            Name = resultEntity.Name,
            Phone = resultEntity.Phone,
            WebSite = resultEntity.WebSite,
            Id = resultEntity.Id
        };
    }
}