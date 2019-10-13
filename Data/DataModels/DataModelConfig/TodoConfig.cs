using System;
using Microsoft.EntityFrameworkCore;
using TodoData.DataModel;

namespace Data.DataModels.DataModelConfig
{
    public class TodoConfig : IEntityTypeConfiguration<TodoDataModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TodoDataModel> builder)
        {
            //This is where we configure mapping. Entity model for Entity Framework for our Data Model

            builder.HasKey(prop => prop.TodoId);

            builder.Property(prop => prop.CreatedOn)
                    .HasColumnType("TIMESTAMP(0)")
                    .IsRequired();

            builder.Property(prop => prop.Body)
                .HasMaxLength(1000);

            builder.Property(prop => prop.Title)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.IsCompleted)
                .IsRequired();
        }

    }
}
