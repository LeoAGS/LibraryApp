using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Data;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options) { }

    public DbSet<Livro> Livros => Set<Livro>();
}
