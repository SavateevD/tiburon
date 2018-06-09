using _tiburon.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _tiburon.Models
{
    public class RespondentContext : DbContext
    {
        public DbSet<Respondent> Respondents { get; set; }
        public DbSet<PhoneMark> PhoneMarks { get; set; }
        public RespondentContext(DbContextOptions<RespondentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RespondetnPhoneMark>()
                .HasKey(bc => new { bc.PhoneMarkId, bc.RespondentId });

            modelBuilder.Entity<RespondetnPhoneMark>()
                .HasOne(bc => bc.PhoneMark)
                .WithMany(b => b.RespondetnPhoneMarks)
                .HasForeignKey(bc => bc.PhoneMarkId);

            modelBuilder.Entity<RespondetnPhoneMark>()
                .HasOne(bc => bc.Respondent)
                .WithMany(c => c.RespondetnPhoneMarks)
                .HasForeignKey(bc => bc.RespondentId);
        }

    }
}
