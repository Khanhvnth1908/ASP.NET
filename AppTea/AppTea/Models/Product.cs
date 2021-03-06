﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AppTea.Models
{
    public class Product
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Desciption { get; set; }

        public string Img { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }


        public double Discount { get; set; }

        public string Status { get; set; }

        public string Category { get; set; }
    }
}
