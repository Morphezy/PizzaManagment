using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.DataBase.DBConfig;

public class PizzasConfig : IEntityTypeConfiguration<Pizza>
{
    public void Configure(EntityTypeBuilder<Pizza> builder)
    {
        builder.HasKey(x => x.Id);
        
        builder.HasOne(p => p.Order)
            .WithMany(o => o.Pizzas)
            .OnDelete(DeleteBehavior.Cascade);
    }
}