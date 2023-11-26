using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamerGearAppWeb.Pages;

public class EdicaoModel : PageModel
{
    private IProdutoService _service;

    public EdicaoModel(IProdutoService produtoService)
    {
        _service = produtoService;
    }

    [BindProperty]
    public Periferico Periferico { get; set; }

    public void OnGet(int id)
        => Periferico = _service.Obter(id);

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _service.Alterar(Periferico);

        return RedirectToPage("/Index");
    }

    public IActionResult OnPostDelete()
    {
        _service.Excluir(Periferico.PerifericoId);

        TempData["TempMensagemSucesso"] = true;

        return RedirectToPage("/Index");
    }
}
