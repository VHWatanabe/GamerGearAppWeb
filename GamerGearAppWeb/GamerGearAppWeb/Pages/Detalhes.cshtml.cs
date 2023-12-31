using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamerGearAppWeb.Pages;

public class DetalhesModel : PageModel
{
    private IProdutoService _service;
    
    public DetalhesModel(IProdutoService produtoService)
    {
        _service = produtoService;
    }

    public Periferico Periferico { get; private set; }
    public Marca Marca { get; private set; }

    public IActionResult OnGet(int id)
    {
        Periferico = _service.Obter(id);
        Marca = _service.ObterTodasMarcas().SingleOrDefault(item => item.MarcaId == Periferico.MarcaId);

        if (Periferico == null)
        {
            return NotFound();
        }

        return Page();
    }
}
