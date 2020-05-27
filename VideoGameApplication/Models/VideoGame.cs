using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameApplication.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int MinimumPlayer { get; set; }
        public int MaximumPlayer { get; set; }

    }
}
