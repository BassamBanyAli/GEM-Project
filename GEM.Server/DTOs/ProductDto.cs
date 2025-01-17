﻿namespace GEM.Server.DTOs
{
    public class ProductDto
    {
        public string? ProductName { get; set; }

        public IFormFile? Image { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int? CategoryId { get; set; }

    }
}
