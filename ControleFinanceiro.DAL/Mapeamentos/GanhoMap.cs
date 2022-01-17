using ControleFinanceiro.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.DAL.Mapeamentos
{
    public class GanhoMap : IEntityTypeConfiguration<Ganho>
    {
        public void Configure(EntityTypeBuilder<Ganho> builder)
        {
            builder.HasKey(g => g.GanhoId);

            builder.Property(g => g.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(g => g.Valor).IsRequired();
            builder.Property(g => g.Dia).IsRequired();
            builder.Property(g => g.Ano).IsRequired();

            builder.HasOne(g => g.Categoria).WithMany(g => g.Ganhos).HasForeignKey(d => d.CategoriaId).IsRequired();
            builder.HasOne(g => g.Mes).WithMany(g => g.Ganhos).HasForeignKey(d => d.MesId).IsRequired();
            builder.HasOne(d => d.Usuario).WithMany(d => d.Ganhos).HasForeignKey(d => d.UsuarioId).IsRequired();

            builder.ToTable("Ganhos");
        }
    }
}
