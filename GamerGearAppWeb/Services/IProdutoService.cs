using GamerGearAppWeb.Models;

namespace GamerGearAppWeb.Services;

public interface IProdutoService
{
    IList<Periferico> ObterTodos();
    Periferico Obter(int id);
    void Incluir(Periferico periferico);
    void Alterar(Periferico periferico);
    void Excluir(int id);
}
