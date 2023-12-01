using GamerGearAppWeb.models;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data;

#nullable disable

namespace GamerGearAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new GamerGearDbContext();
            context.Marca.AddRange(ObterCargaInicial());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicial()
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
}
