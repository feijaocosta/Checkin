using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkin.Models;
using Microsoft.EntityFrameworkCore;

namespace Checkin.Data
{
    public class CheckinContext : DbContext
    {
        public CheckinContext(DbContextOptions<CheckinContext> options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; } = default!;
    }
}
