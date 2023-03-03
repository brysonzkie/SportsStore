﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Bustamante_SportsStore.Models
{
    public class Product
    {
        public long? ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = String.Empty;
        [Column(TypeName = "decimal(8, 2")]
        public decimal Price { get; set; }  
        public string Category { get; set; } = String.Empty;
    }
}
