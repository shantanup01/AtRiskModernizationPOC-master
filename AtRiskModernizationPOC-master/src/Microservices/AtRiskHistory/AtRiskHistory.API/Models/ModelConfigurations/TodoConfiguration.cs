using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AtRiskHistory.Models.ModelConfigurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<AtRiskHistory>
    {
        public void Configure(EntityTypeBuilder<AtRiskHistory> builder)
        {
            builder.HasKey(prop => prop.ID);
                
            builder.Property(prop => prop.GIN)
                .HasColumnType("BIGINT");

            builder.Property(prop => prop.BEGINDATE)
                .HasColumnType("TIMESTAMP(0)")
                .IsRequired();

            builder.Property(prop => prop.CHANGETYPE)
               .HasColumnType("TEXT")
               .HasMaxLength(300);

            builder.Property(prop => prop.LASTCHANGE)
                .HasColumnType("TIMESTAMP(0)")
                .IsRequired();

            builder.Property(prop => prop.LASTCHANGEBY)
               .HasColumnType("BIGINT");

            builder.Property(prop => prop.LASTCHANGEROLE)
               .HasColumnType("TEXT")
               .HasMaxLength(300);

            builder.Property(prop => prop.BEFORE)
               .HasColumnType("TEXT")
               .HasMaxLength(300);

            builder.Property(prop => prop.AFTER)
               .HasColumnType("TEXT")
               .HasMaxLength(300);

        }
    }
}
