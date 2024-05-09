// Dependency Inversion : If Hight Level Module Dependency on Low Level Module Both Of Them Must Be Dependency On Abstraction.
using System;

namespace DI
{
    public interface IProductService
    {
        public void Add(string s);
    }

    public class ProductService : IProductService
    {
        public void Add(string s) { }
    }

    public class ProductRepository
    {
        private readonly IProductService _product;

        public ProductRepository(IProductService product)
        {
            _product = product;
        }

        public bool Add(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                _product.Add(s);
                return true;
            }
            return false;
        }
    }
}
