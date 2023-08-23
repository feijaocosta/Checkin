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
    public class DetailsModel : PageModel
    {
        private readonly Checkin.Data.CheckinContext _context;

        public DetailsModel(Checkin.Data.CheckinContext context)
        {
            _context = context;
        }

      public Evento Evento { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Eventos == null)
            {
                return NotFound();
            }

            var evento = await _context.Eventos.FirstOrDefaultAsync(m => m.Id == id);
            if (evento == null)
            {
                return NotFound();
            }
            else 
            {
                Evento = evento;
            }
            return Page();
        }
    }
}
