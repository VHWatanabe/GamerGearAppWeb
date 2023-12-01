using GamerGearAppWeb.models;
using GamerGearAppWeb.Models;
namespace GamerGearAppWeb.Services.Memory;

public class ProdutoService : IProdutoService
{
    private IList<Periferico> _produtos;

    public ProdutoService()
        => CarregarListaInicial();

    private void CarregarListaInicial()
    {
        _produtos = new List<Periferico>()
        {
            new Periferico
            {
                PerifericoId = 1,
                Nome = "Microfone HyperX QuadCast S",
                Descricao = "Microfone independente ideal com todos os recursos para o streamer ou podcaster que procura um microfone com som de qualidade.",
                Imagem = "/img/Microfone-HyperX-QuadCast-S.png",
                Preco = 699.99,
                Cor = "Preto",
                Marca = "HyperX",
                Peso = 300,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 32,
            },
            new Periferico
            {
                PerifericoId = 2,
                Nome = "Mouse Logitech G Pro Superlight",
                Descricao = "Mouse PRO mais leve e rápido de todos os tempos. Com tecnologia LIGHTSPEED, foi desenvolvido para ajudá-lo a remover todos os obstáculos, para que você possa se concentrar exclusivamente em vencer.",
                Imagem = "/img/Mouse-Logitech-G-PRO-Superlight.png",
                Preco = 569.99,
                Cor = "Preto",
                Marca = "Logitech",
                Peso = 316,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 25,
            },
            new Periferico
            {
                PerifericoId = 3,
                Nome = "Mousepad FalleN Cache Speed ++ (45x45)",
                Descricao = "Pensado e elaborado para amantes do Esports, com acabamento de alta qualidade, resistente à água e costura tripla em suas bordas infinitas que não desfiam.",
                Imagem = "/img/Mousepad-FalleN-Cache.png",
                Preco = 99.99,
                Cor = "Colorido",
                Marca = "FalleN",
                Peso = 400,
                EntregaGratis = false,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 85,
            },
            new Periferico
            {
                PerifericoId = 4,
                Nome = "Mouse Bungee Zowie Camade 2",
                Descricao = "O Mouse Bungee BenQ Zowie Camade II possui um design exclusivo com mola ajustável, permitindo que os usuários escolham entre 3 opções de altura. Além de permitir que os jogadores ajustem a folga do cabo, para movimentos rápidos e desobstruídos.",
                Imagem = "/img/Mouse-Bungee-Zowie-Camade-2.png",
                Preco = 159.99,
                Cor = "Preto/Vermelho",
                Marca = "Zowie",
                Peso = 550,
                EntregaGratis = false,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 3,
            },
            new Periferico
            {
                PerifericoId = 5,
                Nome = "Cadeira Gamer Corsair T3 Rush",
                Descricao = "A cadeira gamer CORSAIR T3 RUSH combina um design inspirado pelas corridas e conforto ergonômico com um exterior suave em tecido respirável, almofada acolchoada para o pescoço e suporte para lombar em viscoelástico que proporcionam conforto para jogos durante todo o dia, enquanto uma estrutura de aço sólida incorporada garante anos de durabilidade.",
                Imagem = "/img/Cadeira-Gamer-Corsair-T3-Rush.png",
                Preco = 1899.99,
                Cor = "Cinza",
                Marca = "Corsair",
                Peso = 22500,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 12,
            },
            new Periferico
            {
                PerifericoId = 6,
                Nome = "Headset HyperX Cloud 2",
                Descricao = "Desperte seu desempenho de jogo com o incrível headset hyperx cloud 2! Com som surround virtual 7.1, microfone removível e acolchoado para maior conforto, você terá uma experiência de jogo imersiva.",
                Imagem = "/img/Headset-HyperX-Cloud-2.png",
                Preco = 369.99,
                Cor = "Branco/Rosa",
                Marca = "HyperX",
                Peso = 1108,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 48,
            },
            new Periferico
            {
                PerifericoId = 7,
                Nome = "Mousepad Razer Firefly V2 Chroma",
                Descricao = "Mousepad Razer Firefly V2 Chroma",
                Imagem = "/img/Mousepad-Razer-Firefly-V2-Chroma.png",
                Preco = 474.99,
                Cor = "Preto",
                Marca = "Razer",
                Peso = 330,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 82,
            },
            new Periferico
            {
                PerifericoId = 8,
                Nome = "Teclado HyperX Alloy Origins 60",
                Descricao = "O HyperX Alloy Origins 60 é um teclado extremamente portátil com 60% do tamanho de um teclado convencional que oferece mais espaço para movimentos amplos do mouse. Com o seu novo teclado, você ainda pode configurar e personalizar o modo de jogo, criar macros e configurar iluminação e feitos diferenciados por tecla. è muita tecnologia e efeito para um setup personalizado como você merece.",
                Imagem = "/img/Teclado-HyperX-Alloy-Origins-60.png",
                Preco = 399.99,
                Cor = "Preto",
                Marca = "HyperX",
                Peso = 970,
                EntregaGratis = true,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 46,
            },
            new Periferico
            {
                PerifericoId = 9,
                Nome = "Webcam Redragon Fobos 2",
                Descricao = "Com uma resolução de 720P e foco fixo a Redragon Fobos 2 proporciona altíssima qualidade para sua stream.",
                Imagem = "/img/Webcam-Redragon-Fobos-2.png",
                Preco = 166.85,
                Cor = "Preto",
                Marca = "Readragon",
                Peso = 300,
                EntregaGratis = false,
                PrecoValido = new DateTime(2023, 11, 30),
                Estoque = 94,
            },
        };
    }

    public IList<Periferico> ObterTodos()
        => _produtos;

    public Periferico Obter(int id)
    {
        return _produtos.SingleOrDefault(item => item.PerifericoId == id);
    }

    public void Incluir(Periferico produto)
    {
        var proximoId = _produtos.Max(item => item.PerifericoId) + 1;
        produto.PerifericoId = proximoId;
        _produtos.Add(produto);
    }

    public void Alterar(Periferico produto)
    {
        var produtoEncontrado = Obter(produto.PerifericoId);
        produtoEncontrado.Nome = produto.Nome;
        produtoEncontrado.Descricao = produto.Descricao;
        produtoEncontrado.Imagem = produto.Imagem;
        produtoEncontrado.Cor = produto.Cor;
        produtoEncontrado.Marca = produto.Marca;
        produtoEncontrado.EntregaGratis = produto.EntregaGratis;
        produtoEncontrado.PrecoValido = produto.PrecoValido;
        produtoEncontrado.Estoque = produto.Estoque;
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _produtos.Remove(produtoEncontrado);

    }

    public IList<Marca> ObterTodasMarcas()
    {
        return new List<Marca>()
            {
                new Marca() {Descricao = "Corsair"},
                new Marca() {Descricao = "HyperX"},
                new Marca() {Descricao = "Zowie"},
                new Marca() {Descricao = "Logitech"},
                new Marca() {Descricao = "FalleN"},
                new Marca() {Descricao = "FalleN"},
                new Marca() {Descricao = "Razer"},
                new Marca() {Descricao = "Redragon"},
            };
    }
}
