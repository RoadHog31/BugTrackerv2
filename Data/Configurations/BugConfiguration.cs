using BugTrackerv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTrackerv2.Data.Configurations
{
    public class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.Property(b => b.Title).HasColumnName("Bug Title");
        }




    }
}