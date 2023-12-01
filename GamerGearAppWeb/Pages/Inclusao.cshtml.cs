using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamerGearAppWeb.Pages;

public class InclusaoModel : PageModel
{
    private IProdutoService _service;
    public SelectList MarcaOptionItems { get; set; }

    public InclusaoModel (IProdutoService produtoService)
    {
        _service = produtoService;
    }

    public void OnGet()
    {
        MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(), nameof(Marca.MarcaId), nameof(Marca.Descricao));
    }

    [BindProperty]
    public Periferico Periferico { get; set; }

    public IActionResult OnPost()
    {

        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Incluir(Periferico);

        return RedirectToPage("/Index");
    }
}
