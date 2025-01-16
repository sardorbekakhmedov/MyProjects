﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Payments.Orders.Domain.Entities;

namespace Payments.Orders.Domain;

public sealed class OrdersDbContext : IdentityDbContext<UserEntity, IdentityRoleEntity, long>
{
    public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
    {
        if (Database.GetPendingMigrations().Any())
        {
            Database.Migrate();
        }
    }

    public DbSet<CustomerEntity> Customers { get; set; } = null!;
    public DbSet<CartEntity> Carts { get; set; } = null!;
    public DbSet<CartItemEntity> CartItems { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<MerchantEntity> Merchants { get; set; } = null!;
}