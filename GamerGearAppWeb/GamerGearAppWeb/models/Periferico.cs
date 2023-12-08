using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;

namespace GamerGearAppWeb.Models;
public class Periferico
{
    public int PerifericoId { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Nome' é obrigatório.")]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve conter entre 10 e 50 caracteres.")]
    public string Nome { get; set; }

    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [Display(Name = "Descrição")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Descrição' é obrigatório.")]
    [StringLength(500, MinimumLength = 50, ErrorMessage = "Campo 'Descrição' deve conter entre 50 e 500 caracteres.")]
    public string Descricao { get; set; }

    [Display(Name = "Caminho da Imagem")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Caminho da Imagem' é obrigatório.")]
    public string Imagem { get; set; }

    [Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Preço' é obrigatório.")]
    public double Preco { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Cor' é obrigatório.")]
    public string Cor { get; set; }

    [Display(Name = "Peso (g)")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Peso' é obrigatório.")]
    public double Peso { get; set; }

    [Display(Name = "Entrega Grátis")]
    public bool EntregaGratis { get; set; }

    public string EntregaGratisFormatada => EntregaGratis ? "Sim" : "Não";

    [Display(Name = "Preço Válido Até")]
    [DisplayFormat(DataFormatString = "{0:MMMM \\de yyyy}")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Preço Válido Até' é obrigatório.")]
    [DataType("month")]
    public DateTime PrecoValido { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Estoque' é obrigatório.")]
    public int Estoque { get; set; }

    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }
}
