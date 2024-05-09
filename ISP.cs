// Interface Segraregation : ISP If you have large interface you must split it into smaller inrerfaces to Easier to Used.

using System;

namespace ISP
{
    public interface ProductService
    {
        public void AddProduct();
        public void RemoveProduct();
        public void UpdateProduct();
        public List<string> GetAll();
        public string GetById(int id);
        public bool SendMessage(string Name);
        public bool AddOrder(object obj);
        public list<string> GetAllOrder();
    }

    // This is Large Interface we could Split it into Samller Interfaces

    // CrudProduct interface

    public interface CrudProduct
    {
        public void AddProduct();
        public void RemoveProduct();
        public void UpdateProduct();
        public List<string> GetAll();
        public string GetById(int id);
    }

    // SendMessageService


    public interface SendMessageService
    {
        public bool SendMessage(string Name);
    }

    // OrderProductService

    public interface OrderProductService
    {
        public bool AddOrder(object obj);
        public list<string> GetAllOrder();
    }
}
