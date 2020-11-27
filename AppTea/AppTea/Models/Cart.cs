﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppTea.Models
{
    public class Cart
    {
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }

        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Product.ID == product.ID)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product)
            => Lines.RemoveAll(l => l.Product.ID == product.ID);

        public decimal ComputeTotalValue()
            => Lines.Sum(e => e.Product.Price * e.Quantity);

        public void Clear()
            => Lines.Clear();
    }
}