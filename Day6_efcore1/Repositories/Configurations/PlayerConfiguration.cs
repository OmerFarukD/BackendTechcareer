using Day6_efcore1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Day6_efcore1.Repositories.Configurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.ToTable("Players_db").HasKey(p=>p.Id);
        builder.Property(p => p.Id).HasColumnName("player_id");
        builder.Property(p=>p.Name).HasColumnName("player_name");
        builder.Property(p => p.OutfitId).HasColumnName("outfit_id");
        builder.Property(p => p.Age).HasColumnName("player_age");
        builder.Property(p => p.BranchId).HasColumnName("branch_id");
        builder.Property(p => p.TeamId).HasColumnName("team_id");
        builder.Property(p => p.Price).HasColumnName("player_price");

        builder.HasOne(p => p.Team);
        builder.HasOne(p => p.Outfit);
        builder.HasOne(p => p.Branch);


    }
}
