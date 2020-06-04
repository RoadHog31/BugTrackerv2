using BugTrackerv2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BugTracker.Data.Configurations
{
    public class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.Property(b => b.Title).HasColumnName("Bug Title");
        }

        public void Configure(EntityTypeBuilder<Models.BugType> builder)
        {
            builder.Property(b => b.Id).HasColumnName("Bug Type Id");
        }

        public void Configure(EntityTypeBuilder<Models.BugPriority> builder)
        {
            builder.Property(b => b.Id).HasColumnName("Bug Priority Id");
        }

        public void Configure(EntityTypeBuilder<Models.BugSeverity> builder)
        {
            builder.Property(b => b.Id).HasColumnName("Bug Severity Id");
        }


    }
}