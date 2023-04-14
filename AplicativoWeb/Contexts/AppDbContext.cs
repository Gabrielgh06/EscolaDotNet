using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.Models; //Chamando a camada Modelo
using AplicativoWeb.EntityConfigs;

    //dbContext representa o banco de dados
public class AppDbContext:DbContext{

    //dbSet Representa a tabela
    public DbSet<Curso> Cursos => Set<Curso>(); //representa a tabela //Seta (atribui) a classe Curso com a entidade no banco de dados (context) EscolaDotNet
    // public DbSet<Disciplina> Disciplinas => Set<disciplina>();


    // override (sobrescrever) 
    // protected - somente os filhos que vão poder acessar
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        //builder.UseSqlServer("servidor; bancodedados; usuario; senha; cerificado");
        builder.UseSqlServer("Server = LAB-F08-23;Database=EscolaDotNet; User Id=sa; Password=Senai@123; TrustServerCertificate=True");
        
    }

    protected override void OnModelCreating(ModelBuilder builder){
        builder.ApplyConfiguration(new CursoEntityConfig());
    }
}