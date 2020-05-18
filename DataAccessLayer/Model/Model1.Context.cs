﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbMvcEF2Entities : DbContext
    {
        public dbMvcEF2Entities()
            : base("name=dbMvcEF2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AuthorDetail> AuthorDetails { get; set; }
        public virtual DbSet<AuthorsBook> AuthorsBooks { get; set; }
        public virtual DbSet<Book> Books { get; set; }
    
        public virtual int DeleteBulkAuthor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteBulkAuthor");
        }
    
        public virtual int InsertBulkAuthore()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertBulkAuthore");
        }
    
        public virtual int UpdateBulkAuthor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateBulkAuthor");
        }
    }
}
