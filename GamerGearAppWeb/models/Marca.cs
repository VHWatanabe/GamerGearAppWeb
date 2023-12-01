using GamerGearAppWeb.Models;

namespace GamerGearAppWeb.models;

public class Marca
{
    public int MarcaId { get; set; }
    public string Descricao { get; set; }

    public ICollection<Periferico> Perifericos { get; set;}
}
