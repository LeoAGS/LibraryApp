using BibliotecaApi.Data;
using BibliotecaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private readonly BibliotecaContext _context;

    public LivrosController(BibliotecaContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Livro>>> GetLivros()
    {
        return await _context.Livros.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Livro>> PostLivro(Livro livro)
    {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();
        return livro;
    }
}
