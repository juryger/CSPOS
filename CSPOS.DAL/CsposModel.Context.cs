﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSPOS.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class csposEntities : DbContext
    {
        public csposEntities()
            : base("name=csposEntities")
        {
        }
    
    	public csposEntities(string connectionString)
            : base(connectionString)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<catalog> catalogs { get; set; }
        public virtual DbSet<orderitem> orderitems { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<catalogcategory> catalogcategories { get; set; }
        public virtual DbSet<catalogcondition> catalogconditions { get; set; }
        public virtual DbSet<catalogmaker> catalogmakers { get; set; }
        public virtual DbSet<catalogtype> catalogtypes { get; set; }
        public virtual DbSet<orderstatus> orderstatuses { get; set; }
    }
}
