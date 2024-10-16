﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace ClassLib
{
    public class DB : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DB() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Lab3DB.db");
        }
        public void ClearDatabase()
        {
            Employees.RemoveRange(Employees);
            Departments.RemoveRange(Departments);
            SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)   // Один работник имеет один департамент
                .WithMany(d => d.Employees)  // Один департамент имеет много работников
                .HasForeignKey(e => e.DepartmentId);  // Внешний ключ в таблице работников
        }
    }
}