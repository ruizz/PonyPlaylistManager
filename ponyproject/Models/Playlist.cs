using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ponyproject.Models
{
    public class Playlist
    {
        public DateTime dateAdded { get; set; }
        public int id { get; set; }
    }

    public class PlaylistContext : DbContext
    {
        public DbSet<Playlist> Playlists { get; set; }
    }
}
