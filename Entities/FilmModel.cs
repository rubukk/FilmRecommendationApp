﻿namespace FilmRecommendationApp.Entities
{
    public class FilmModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Genre { get; set; }
        public string? Description { get; set; }
    }
}