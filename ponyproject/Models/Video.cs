using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ponyproject.Models
{
    public class Video
    {
        public string title { get; set; }
        public string link { get; set; }
        public DateTime dateAdded { get; set; }
        public int score { get; set; }
        public int id { get; set; }
        public int playlistId { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}