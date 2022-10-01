using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao_d7_interface_de_usuario.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User() {Id= Guid.NewGuid(),  Email="admin@email.com", Password="admin123"});
            base.OnModelCreating(modelBuilder);
        }
    }
}
