﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
            : base("name=DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contest> Contests { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersContest> UsersContests { get; set; }
        public virtual DbSet<Result> Results { get; set; }
    }
}
