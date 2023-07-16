using GUI_Project_4162_4271.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project_4162_4271.Context
{
    public class NormalUserContext : DbContext
    {
        public DbSet<NormalUser> NormalUsers { get; set; }
        private readonly string path = @"H:\Ruh_eng_2020\Academic\semester3\programing project\GUI_Project_4162_4271\GUI_Project_4162_4271\NormalUsers.db";

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data source={path}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NormalUser>().HasKey(n => n.NormalUserId); // Set Id as primary key
        }

    }
}
