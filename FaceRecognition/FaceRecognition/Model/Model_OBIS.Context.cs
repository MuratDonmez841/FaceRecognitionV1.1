﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceRecognition.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBOBISEntities : DbContext
    {
        public DBOBISEntities()
            : base("name=DBOBISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_DERS> T_DERS { get; set; }
        public virtual DbSet<T_KEY> T_KEY { get; set; }
        public virtual DbSet<T_OGR> T_OGR { get; set; }
    }
}
