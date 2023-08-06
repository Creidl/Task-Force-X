using Microsoft.EntityFrameworkCore;
using Task_Force.Entities;

namespace Task_Force.Data
{
    public class TaskForceDbContext : DbContext
    {
        DbSet<ToDoOnce> ToDos => Set<ToDoOnce>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("ToDosStorageDb");
        }
    }
}