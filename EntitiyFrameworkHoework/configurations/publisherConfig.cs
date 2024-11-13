using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyFrameworkHoework.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntitiyFrameworkHoework.configurations
{
    public class publisherConfig : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.Property(i => i.id).IsRequired();
            builder.Property(i => i.name).IsRequired().HasMaxLength(30);
            builder.HasMany(i => i.books).WithOne(j => j.publisher).HasForeignKey(k => k.id);
        }
    }
}
