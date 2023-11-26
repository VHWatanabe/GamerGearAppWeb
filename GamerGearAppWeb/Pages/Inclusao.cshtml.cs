using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamerGearAppWeb.Pages;

public class InclusaoModel : PageModel
{
    private IProdutoService _service;

    public InclusaoModel (IProdutoService produtoService)
    {
        _service = produtoService;
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
