using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sugaru_Iulia_Lab2.Models;

namespace Sugaru_Iulia_Lab2.Data
{
    public class Sugaru_Iulia_Lab2Context : DbContext
    {
        public Sugaru_Iulia_Lab2Context (DbContextOptions<Sugaru_Iulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sugaru_Iulia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sugaru_Iulia_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Sugaru_Iulia_Lab2.Models.Author> Author { get; set; }

        public DbSet<Sugaru_Iulia_Lab2.Models.Category> Category { get; set; }
        public DbSet<Sugaru_Iulia_Lab2.Models.Member> Member { get; set; }
        public DbSet<Sugaru_Iulia_Lab2.Models.Borrowing> Borrowing { get; set; }


    }
}
