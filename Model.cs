using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace NotesDemo
{
    public class NotesContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        // public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433; Database=NotesDb;User=sa; Password=MyPass@word");
    }

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }

        [DefaultValue(false)]
        public bool IsAdmin { get; set; } = false;

    }

}