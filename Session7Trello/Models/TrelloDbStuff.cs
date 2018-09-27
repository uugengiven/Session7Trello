using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session7Trello.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        
        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Note> Notes { get; set; }
    }

    public class NoteDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}