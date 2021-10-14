using CollectionExecutor.Model;
using CollectionExecutor.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollectionExecutor.Persistence.Mapping
{
    public class RequestMap : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(k => k.RequestId);
            builder.Property(p => p.CollectionId).HasColumnType(SqlType.INT);
            builder.Property(p => p.Name).HasColumnType(SqlType.VARCHAR075);

            /* Virtuals */
            //builder.Ignore(ignore => ignore.Collection);
        }
    }
}
