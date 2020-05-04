using Course.Entities;
using System;
using System.Collections.Generic;

namespace Course.Service
{
    class ProductService
    {
        public double FilteredSum(List<Product> list, Func<Product, bool> func)
        {
            double sum = 0.0;
            foreach (Product p in list)
            {
                if (func.Invoke(p))
                {
                    sum += p.Price;
                }
            }
            return sum;
        }
    }
}
