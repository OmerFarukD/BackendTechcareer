using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day6_efcore1.Repositories.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branch_db").HasKey(c => c.Id);
            builder.Property(b => b.Id).HasColumnName("branch_id");
            builder.Property(b => b.BranchName).HasColumnName("branch_name");
            
            builder.HasMany(b=>b.Players);

            builder.HasData(new Branch() { Id = 1, BranchName = "Football" });
        }
    }
}
