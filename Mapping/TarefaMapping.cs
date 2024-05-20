using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Mapping
{
    public class TarefaMapping : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(c => c.Titulo).HasMaxLength(255);
            builder.Property(c => c.Descricao).HasMaxLength(1000);
            builder.Property(c => c.Data);
            builder.Property(c => c.Status);
        }
    }
}
