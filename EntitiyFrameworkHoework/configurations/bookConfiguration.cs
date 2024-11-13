using Microsoft.EntityFrameworkCore;
using EntitiyFrameworkHoework.entities;

namespace EntitiyFrameworkHoework.configurations
{
    public class bookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.Property(i => i.id).IsRequired();
            builder.Property(i => i.title).IsRequired().HasMaxLength(100);
            builder.HasOne(i => i.publisher).WithMany(j => j.books).HasPrincipalKey(k => k.id);
            builder.HasOne(i => i.author).WithMany(j => j.books).HasPrincipalKey(k => k.id);
        }
    }
}
