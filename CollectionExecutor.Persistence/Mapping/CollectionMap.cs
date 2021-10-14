using CollectionExecutor.Model;
using CollectionExecutor.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollectionExecutor.Persistence.Mapping
{
    public class CollectionMap : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.HasKey(k => k.CollectionId);
            builder.Property(p => p.Name).HasColumnType(SqlType.VARCHAR075);
            builder.Property(p => p.CreatedDate).HasColumnType(SqlType.DATETIME);

            /* Virtuals */
            //builder.Ignore(ignore => ignore.Requests);
        }
    }
}
