﻿namespace ETicaret.Models
{
    public class Actor_Movie
    {
        public Movie Movie { get; set; }

        public int MovieId { get; set; }

        public int ActorId { get; set; }

        public Actor Actor { get; set; }
    }
}
