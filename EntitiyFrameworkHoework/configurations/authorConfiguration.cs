using Microsoft.EntityFrameworkCore;
using EntitiyFrameworkHoework.entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntitiyFrameworkHoework.configurations
{
    public class authorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(i => i.id).IsRequired();
            builder.Property(i => i.firstName).IsRequired().HasMaxLength(30);
            builder.Property(i => i.lastName).IsRequired().HasMaxLength(30);
            builder.HasMany(i => i.books).WithOne(j => j.author).HasForeignKey(k => k.id);
        }
    }
}
