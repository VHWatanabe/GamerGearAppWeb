using GamerGearAppWeb.Data;
using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;

namespace GamerGearAppWeb.Services.Data;

public class ProdutoService : IProdutoService
{

    private GamerGearDbContext _context;

    public ProdutoService(GamerGearDbContext context) {
        _context = context;
    }

    public void Alterar(Periferico periferico)
    {
        var produtoEncontrado = Obter(periferico.PerifericoId);
        produtoEncontrado.Nome = periferico.Nome;
        produtoEncontrado.Descricao = periferico.Descricao;
        produtoEncontrado.Imagem = periferico.Imagem;
        produtoEncontrado.Cor = periferico.Cor;
        produtoEncontrado.MarcaId = periferico.MarcaId;
        produtoEncontrado.EntregaGratis = periferico.EntregaGratis;
        produtoEncontrado.PrecoValido = periferico.PrecoValido;
        produtoEncontrado.Estoque = periferico.Estoque;

        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var perifericoEncontrado = Obter(id);
        _context.Periferico.Remove(perifericoEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Periferico periferico)
    {
        _context.Periferico.Add(periferico);
        _context.SaveChanges();
    }

    public Periferico Obter(int id)
    {
        return _context.Periferico.SingleOrDefault(item => item.PerifericoId == id);
    }

    public IList<Marca> ObterTodasMarcas()
    {
        return _context.Marca.ToList();
    }

    public IList<Periferico> ObterTodos()
    {
        return _context.Periferico.ToList();
    }
}
