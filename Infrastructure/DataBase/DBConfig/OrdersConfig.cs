using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataBase.DBConfig;

public class OrdersConfig : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(o => o.Pizzas)
            .WithOne(p => p.Order)
            .OnDelete(DeleteBehavior.Cascade)
            .HasForeignKey(p => p.OrderId)
            .IsRequired();
    }
}