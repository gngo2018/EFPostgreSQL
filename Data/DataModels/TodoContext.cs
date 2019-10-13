using System;
using Data.DataModels.DataModelConfig;
using Microsoft.EntityFrameworkCore;

namespace TodoData.DataModel
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfiguration(new TodoConfig());

        //Need to make sure that you name the variable exactly as it is in the database
        public DbSet<TodoDataModel> Todo { get; set; }
        //OR

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.ApplyConfiguration(new Configuration());
        //}
    }
}
