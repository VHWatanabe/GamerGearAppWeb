using GamerGearAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GamerGearAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialPeriferico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new GamerGearDbContext();
            context.Periferico.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<Periferico> ObterCargaInicial()
        {
            return new List<Periferico>()
            {
                new Periferico
                {
                    Nome = "Microfone HyperX QuadCast S",
                    Descricao = "Microfone independente ideal com todos os recursos para o streamer ou podcaster que procura um microfone com som de qualidade.",
                    Imagem = "/img/Microfone-HyperX-QuadCast-S.png",
                    Preco = 699.99,
                    Cor = "Preto",
                    Peso = 300,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 32,
                },
                new Periferico
                {
                    Nome = "Mouse Logitech G Pro Superlight",
                    Descricao = "Mouse PRO mais leve e rápido de todos os tempos. Com tecnologia LIGHTSPEED, foi desenvolvido para ajudá-lo a remover todos os obstáculos, para que você possa se concentrar exclusivamente em vencer.",
                    Imagem = "/img/Mouse-Logitech-G-PRO-Superlight.png",
                    Preco = 569.99,
                    Cor = "Preto",
                    Peso = 316,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 25,
                },
                new Periferico
                {
                    Nome = "Mousepad FalleN Cache Speed ++ (45x45)",
                    Descricao = "Pensado e elaborado para amantes do Esports, com acabamento de alta qualidade, resistente à água e costura tripla em suas bordas infinitas que não desfiam.",
                    Imagem = "/img/Mousepad-FalleN-Cache.png",
                    Preco = 99.99,
                    Cor = "Colorido",
                    Peso = 400,
                    EntregaGratis = false,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 85,
                },
                new Periferico
                {
                    Nome = "Mouse Bungee Zowie Camade 2",
                    Descricao = "O Mouse Bungee BenQ Zowie Camade II possui um design exclusivo com mola ajustável, permitindo que os usuários escolham entre 3 opções de altura. Além de permitir que os jogadores ajustem a folga do cabo, para movimentos rápidos e desobstruídos.",
                    Imagem = "/img/Mouse-Bungee-Zowie-Camade-2.png",
                    Preco = 159.99,
                    Cor = "Preto/Vermelho",
                    Peso = 550,
                    EntregaGratis = false,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 3,
                },
                new Periferico
                {
                    Nome = "Cadeira Gamer Corsair T3 Rush",
                    Descricao = "A cadeira gamer CORSAIR T3 RUSH combina um design inspirado pelas corridas e conforto ergonômico com um exterior suave em tecido respirável, almofada acolchoada para o pescoço e suporte para lombar em viscoelástico que proporcionam conforto para jogos durante todo o dia, enquanto uma estrutura de aço sólida incorporada garante anos de durabilidade.",
                    Imagem = "/img/Cadeira-Gamer-Corsair-T3-Rush.png",
                    Preco = 1899.99,
                    Cor = "Cinza",
                    Peso = 22500,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 12,
                },
                new Periferico
                {
                    Nome = "Headset HyperX Cloud 2",
                    Descricao = "Desperte seu desempenho de jogo com o incrível headset hyperx cloud 2! Com som surround virtual 7.1, microfone removível e acolchoado para maior conforto, você terá uma experiência de jogo imersiva.",
                    Imagem = "/img/Headset-HyperX-Cloud-2.png",
                    Preco = 369.99,
                    Cor = "Branco/Rosa",
                    Peso = 1108,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 48,
                },
                new Periferico
                {
                    Nome = "Mousepad Razer Firefly V2 Chroma",
                    Descricao = "Mousepad Razer Firefly V2 Chroma",
                    Imagem = "/img/Mousepad-Razer-Firefly-V2-Chroma.png",
                    Preco = 474.99,
                    Cor = "Preto",
                    Peso = 330,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 82,
                },
                new Periferico
                {
                    Nome = "Teclado HyperX Alloy Origins 60",
                    Descricao = "O HyperX Alloy Origins 60 é um teclado extremamente portátil com 60% do tamanho de um teclado convencional que oferece mais espaço para movimentos amplos do mouse. Com o seu novo teclado, você ainda pode configurar e personalizar o modo de jogo, criar macros e configurar iluminação e feitos diferenciados por tecla. è muita tecnologia e efeito para um setup personalizado como você merece.",
                    Imagem = "/img/Teclado-HyperX-Alloy-Origins-60.png",
                    Preco = 399.99,
                    Cor = "Preto",
                    Peso = 970,
                    EntregaGratis = true,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 46,
                },
                new Periferico
                {
                    Nome = "Webcam Redragon Fobos 2",
                    Descricao = "Com uma resolução de 720P e foco fixo a Redragon Fobos 2 proporciona altíssima qualidade para sua stream.",
                    Imagem = "/img/Webcam-Redragon-Fobos-2.png",
                    Preco = 166.85,
                    Cor = "Preto",
                    Peso = 300,
                    EntregaGratis = false,
                    PrecoValido = new DateTime(2023, 11, 30),
                    Estoque = 94,
                },
            };
        }
    }
}
