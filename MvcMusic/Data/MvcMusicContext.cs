using Microsoft.EntityFrameworkCore;
using MvcMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMusic.Data
{
    public class MvcMusicContext : DbContext
    {
        public MvcMusicContext(DbContextOptions<MvcMusicContext> options)
            : base(options)
        {
        }

        public DbSet<Music> Music { get; set; }
    }
}

