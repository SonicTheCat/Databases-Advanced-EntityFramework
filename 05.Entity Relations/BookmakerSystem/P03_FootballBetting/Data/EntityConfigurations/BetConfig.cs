﻿namespace P03_FootballBetting.Data.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using P03_FootballBetting.Data.Models;

    public class BetConfig : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> builder)
        {
            builder.HasKey(b => b.BetId);

            builder.HasOne(b => b.Game)
                   .WithMany(g => g.Bets)
                   .HasForeignKey(b => b.GameId);

            builder.HasOne(b => b.User)
                  .WithMany(u => u.Bets)
                  .HasForeignKey(b => b.UserId);
        }
    }
}