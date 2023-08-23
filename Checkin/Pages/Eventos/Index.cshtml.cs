using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Checkin.Data;
using Checkin.Models;

namespace Checkin.Pages.Eventos
{
    public class IndexModel : PageModel
    {
        private readonly Checkin.Data.CheckinContext _context;

        public IndexModel(Checkin.Data.CheckinContext context)
        {
            _context = context;
        }

        public IList<Evento> Evento { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Eventos != null)
            {
                Evento = await _context.Eventos.ToListAsync();
            }
        }
    }
}
