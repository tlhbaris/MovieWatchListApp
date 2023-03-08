using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieWatchList.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MovieWatchList.DataAccess
{
    public class MovieDbContext : IdentityDbContext<User>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-FHJR7J7;Initial Catalog=MovieListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Follow>().HasMany(i => i.UserId).WithRequired().WillCascadeOnDelete(false);


            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

         



            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasIndex(x => x.Id);
                

            });

            modelBuilder.Entity<MovieList>(entity =>
            {
                entity.HasIndex(x => x.MovieListId);
                entity.Property(x => x.ListName).HasMaxLength(50).IsRequired();

            });
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasIndex(x => x.CommentId);

            });

            //modelBuilder.Entity<Comment>()
                        //.HasKey(x => new { x.UserId, x.CommentId,x.MovieListId });
                        //.HasOne(b => b.Comment).WithOne(c => c.).HasForeignKey<BankAccount>(f => f.Id);
                        //.HasIndex(x => x.CommentId);

            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            modelBuilder.Entity<MovieListMovie>()
                        .HasKey(x => new { x.ExternalApiId, x.MovieListId});

            modelBuilder.Entity<Follow>()
                        .HasKey(x => new { x.UserId, x.GetFollowId });                    


        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieList> MoviesLists { get; set; }
        public DbSet<MovieListMovie> MoviesListMovies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }

        //public DbSet<FollowUser> FollowUsers { get; set; }




    }
}
