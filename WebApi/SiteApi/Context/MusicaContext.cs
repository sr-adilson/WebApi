using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MusicaContext : DbContext
    {
        public DbSet<Musica> Musica { get; set; }
        public MusicaContext() : base("Data Source=192.168.0.192;Initial Catalog=Adilson;Persist Security Info=True;User ID=Adilson;Password=123")
        {
        }
    }
}
