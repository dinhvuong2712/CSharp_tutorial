﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Entity_Framework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StoriesEntities1 : DbContext
    {
        public StoriesEntities1()
            : base("name=StoriesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<BookMark> BookMarks { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ChapterDirectory> ChapterDirectories { get; set; }
        public virtual DbSet<ChapterImg> ChapterImgs { get; set; }
        public virtual DbSet<Comic> Comics { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Credential> Credentials { get; set; }
        public virtual DbSet<GroupStory> GroupStories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<StatusStory> StatusStories { get; set; }
        public virtual DbSet<UserStory> UserStories { get; set; }
        public virtual DbSet<AuthorsDetail> AuthorsDetails { get; set; }
        public virtual DbSet<CategoriesDetail> CategoriesDetails { get; set; }
    }
}
