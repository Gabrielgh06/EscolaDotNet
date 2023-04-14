using AplicativoWeb.Models; //Camada Model
using Microsoft.EntityFrameworkCore; //EF framework
using Microsoft.EntityFrameworkCore.Metadata.Builders;//Fuient API fazer.UmaCoisa.OutraCoisa.AquelaCoisa
namespace AplicativoWeb.EntityConfigs;//Novo namespace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");
        // Lambda
        //Public void Somar()
        //variável / função

        // Chave primária - Universal, aderente e imutável
        builder.HasKey(c=>c.Id); 
        builder.Property(c=>c.TituloInterno)
               .HasColumnType("nvarchar(80)")
               .IsRequired();
        // 
        builder.Property(c=>c.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired(); 
        // 
        builder.Property(c=>c.Descricao)
               .HasColumnType("text")
               .IsRequired(); 
    }
}

