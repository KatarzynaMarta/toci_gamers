using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Toci.Lgw.Database.Persistence.Models
{
    public partial class TociGamersContext : DbContext
    {
        public TociGamersContext()
        {
        }

        public TociGamersContext(DbContextOptions<TociGamersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competitions { get; set; } = null!;
        public virtual DbSet<Duel> Duels { get; set; } = null!;
        public virtual DbSet<Duelslist> Duelslists { get; set; } = null!;
        public virtual DbSet<Enrolledcompetitor> Enrolledcompetitors { get; set; } = null!;
        public virtual DbSet<Enrolledcompetitorslist> Enrolledcompetitorslists { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Gamer> Gamers { get; set; } = null!;
        public virtual DbSet<Gamerplayedgame> Gamerplayedgames { get; set; } = null!;
        public virtual DbSet<Gamersgame> Gamersgames { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<Teamplayerslist> Teamplayerslists { get; set; } = null!;
        public virtual DbSet<Teamsplayer> Teamsplayers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Toci.Gamers;Username=postgres;Password=dupa1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("competitions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idgames).HasColumnName("idgames");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time");

                entity.HasOne(d => d.IdgamesNavigation)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.Idgames)
                    .HasConstraintName("competitions_idgames_fkey");
            });

            modelBuilder.Entity<Duel>(entity =>
            {
                entity.ToTable("duels");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idgame).HasColumnName("idgame");

                entity.Property(e => e.Idplayerone).HasColumnName("idplayerone");

                entity.Property(e => e.Idplayertwo).HasColumnName("idplayertwo");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.HasOne(d => d.IdgameNavigation)
                    .WithMany(p => p.Duels)
                    .HasForeignKey(d => d.Idgame)
                    .HasConstraintName("duels_idgame_fkey");

                entity.HasOne(d => d.IdplayeroneNavigation)
                    .WithMany(p => p.DuelIdplayeroneNavigations)
                    .HasForeignKey(d => d.Idplayerone)
                    .HasConstraintName("duels_idplayerone_fkey");

                entity.HasOne(d => d.IdplayertwoNavigation)
                    .WithMany(p => p.DuelIdplayertwoNavigations)
                    .HasForeignKey(d => d.Idplayertwo)
                    .HasConstraintName("duels_idplayertwo_fkey");
            });

            modelBuilder.Entity<Duelslist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("duelslist");

                entity.Property(e => e.Gamerone).HasColumnName("gamerone");

                entity.Property(e => e.Gamertwo).HasColumnName("gamertwo");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Result).HasColumnName("result");
            });

            modelBuilder.Entity<Enrolledcompetitor>(entity =>
            {
                entity.ToTable("enrolledcompetitors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idcompetitions).HasColumnName("idcompetitions");

                entity.Property(e => e.Idgamers).HasColumnName("idgamers");

                entity.HasOne(d => d.IdcompetitionsNavigation)
                    .WithMany(p => p.Enrolledcompetitors)
                    .HasForeignKey(d => d.Idcompetitions)
                    .HasConstraintName("enrolledcompetitors_idcompetitions_fkey");

                entity.HasOne(d => d.IdgamersNavigation)
                    .WithMany(p => p.Enrolledcompetitors)
                    .HasForeignKey(d => d.Idgamers)
                    .HasConstraintName("enrolledcompetitors_idgamers_fkey");
            });

            modelBuilder.Entity<Enrolledcompetitorslist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("enrolledcompetitorslist");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Nick).HasColumnName("nick");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Gamer>(entity =>
            {
                entity.ToTable("gamers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nick).HasColumnName("nick");
            });

            modelBuilder.Entity<Gamerplayedgame>(entity =>
            {
                entity.ToTable("gamerplayedgame");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Finish)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("finish");

                entity.Property(e => e.Idgamers).HasColumnName("idgamers");

                entity.Property(e => e.Idgames).HasColumnName("idgames");

                entity.Property(e => e.Start)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("start")
                    .HasDefaultValueSql("now()");

                entity.HasOne(d => d.IdgamersNavigation)
                    .WithMany(p => p.Gamerplayedgames)
                    .HasForeignKey(d => d.Idgamers)
                    .HasConstraintName("gamerplayedgame_idgamers_fkey");

                entity.HasOne(d => d.IdgamesNavigation)
                    .WithMany(p => p.Gamerplayedgames)
                    .HasForeignKey(d => d.Idgames)
                    .HasConstraintName("gamerplayedgame_idgames_fkey");
            });

            modelBuilder.Entity<Gamersgame>(entity =>
            {
                entity.ToTable("gamersgames");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idgamers).HasColumnName("idgamers");

                entity.Property(e => e.Idgames).HasColumnName("idgames");

                entity.HasOne(d => d.IdgamersNavigation)
                    .WithMany(p => p.Gamersgames)
                    .HasForeignKey(d => d.Idgamers)
                    .HasConstraintName("gamersgames_idgamers_fkey");

                entity.HasOne(d => d.IdgamesNavigation)
                    .WithMany(p => p.Gamersgames)
                    .HasForeignKey(d => d.Idgames)
                    .HasConstraintName("gamersgames_idgames_fkey");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.ToTable("results");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Results).HasColumnName("results");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idgame).HasColumnName("idgame");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.HasOne(d => d.IdgameNavigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.Idgame)
                    .HasConstraintName("teams_idgame_fkey");
            });

            modelBuilder.Entity<Teamplayerslist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("teamplayerslist");

                entity.Property(e => e.Game).HasColumnName("game");

                entity.Property(e => e.Nick).HasColumnName("nick");

                entity.Property(e => e.Team).HasColumnName("team");
            });

            modelBuilder.Entity<Teamsplayer>(entity =>
            {
                entity.ToTable("teamsplayers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idgamer).HasColumnName("idgamer");

                entity.Property(e => e.Idteams).HasColumnName("idteams");

                entity.HasOne(d => d.IdgamerNavigation)
                    .WithMany(p => p.Teamsplayers)
                    .HasForeignKey(d => d.Idgamer)
                    .HasConstraintName("teamsplayers_idgamer_fkey");

                entity.HasOne(d => d.IdteamsNavigation)
                    .WithMany(p => p.Teamsplayers)
                    .HasForeignKey(d => d.Idteams)
                    .HasConstraintName("teamsplayers_idteams_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
