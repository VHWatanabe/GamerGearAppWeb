using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;
using GamerGearAppWeb.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamerGearAppWeb.Pages;

[Authorize]
public class EdicaoModel : PageModel
{
    private IProdutoService _service;
    public SelectList MarcaOptionItems { get; set; }

    public EdicaoModel(IProdutoService produtoService)
    {
        _service = produtoService;
    }

    [BindProperty]
    public Periferico Periferico { get; set; }

    public void OnGet(int id)
    {
        Periferico = _service.Obter(id);
        MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(), nameof(Marca.MarcaId), nameof(Marca.Descricao));
    }

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
