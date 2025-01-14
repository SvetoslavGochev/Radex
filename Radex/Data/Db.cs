﻿namespace Radex.Data
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Threading.Tasks;

    public class Db : DbContext
    {
        public Db()
        {

        }

        public Db(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =.; Database = Radex; Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; init; }

        public virtual DbSet<Candidate> Candidates { get; init; }
        public virtual DbSet<Recruiter> Recruiters { get; init; }
        public virtual DbSet<Skills> Skills { get; init; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasOne(x => x.Recruiter)
                .WithMany(x => x.Candidates)
                .HasForeignKey(x => x.RecruiterId)
                .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Candidate>()
            //    .HasOne<Recruiter>()
            //    .WithOne()
            //    .OnDelete(DeleteBehavior.Restrict);
            //one to one 

            base.OnModelCreating(modelBuilder);
        }
    }
}
