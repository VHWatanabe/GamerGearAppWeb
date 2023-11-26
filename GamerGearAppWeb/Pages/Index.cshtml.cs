using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamerGearAppWeb.Pages;
public class IndexModel : PageModel
{
    private IProdutoService _service;
    
    public IndexModel(IProdutoService produtoService)
    {
        _service = produtoService;
    }

    public IList<Periferico> ListaProduto { get; private set; }

    public void OnGet()
    {
        ListaProduto = _service.ObterTodos();
    }   
}