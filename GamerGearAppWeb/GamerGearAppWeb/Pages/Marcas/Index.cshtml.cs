using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GamerGearAppWeb.Data;
using GamerGearAppWeb.models;

namespace GamerGearAppWeb.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly GamerGearAppWeb.Data.GamerGearDbContext _context;

        public IndexModel(GamerGearAppWeb.Data.GamerGearDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}
