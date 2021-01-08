using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vinkler_Robert_Lab6.Models;

namespace Vinkler_Robert_Lab6.Data
{
    public class Vinkler_Robert_Lab6Context : DbContext
    {
        public Vinkler_Robert_Lab6Context (DbContextOptions<Vinkler_Robert_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Vinkler_Robert_Lab6.Models.Book> Book { get; set; }
    }
}
