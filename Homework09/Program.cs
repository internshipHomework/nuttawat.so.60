using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myapp
{
    public interface IHomework09
    {
        IEnumerable<IProduct> GetAllProducts();
        void AddProductToCart(IProduct product);
        IEnumerable<IProduct> GetProductsInCart();
    }
    public interface IProduct 
    {
        string SKU { get; set; }
        string Name { get; set; }
        string Price { get; set; }
    }
    class Method0 : IProduct{
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

    }
    class Method1 : IHomework09
    {
        ArrayList Array = new ArrayList();
        string filepath = @"product.csv";
        List<IProduct> IProductList = new List<IProduct>();
        public void AddProductToCart(string product)
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach(var line in lines)
            {
                string[] entries = line.Split(',');
                IProduct newIProduct = new Method0();
                newIProduct.SKU = entries[0];
                newIProduct.Name = entries[1];
                newIProduct.Price = entries[2];
                IProductList.Add(newIProduct);

            }

            double sum = 1 ;
            for (int i = 1 ; i <= 100 ; i++) {
                Console.WriteLine("Please input a product key:");
                Console.WriteLine("Products in your cart are");
                foreach (var products in IProductList )
                {
                    if (product == products.SKU)
                    {
                        Array.Add( $"{i}. {products.Name}  {products.Price} ");
                        double convertdob = Convert.ToDouble(products.Price);
                        sum += convertdob;
                    }
                    
                    
                
                }
                for(int j = 0 ; j< Array.Count; j++)
                {
                        Console.WriteLine(Array[j]);
                }
                Console.WriteLine("----------"); 
                Console.WriteLine("Total amount: "+ sum + " Bath");
                product = Console.ReadLine();

                
            }
            
        }

        public void AddProductToCart(IProduct product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetAllProducts()  
        {
            return IProductList;
        }
        public IEnumerable<IProduct> GetProductsInCart()
        {
            return IProductList;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Products in your cart are");
            Console.WriteLine("none");
            Console.WriteLine("----------");
            Console.WriteLine("Total amount: 0.00 Bath");
            Method1 panel = new Method1();
            Console.WriteLine("Please input a product key:");
            string a = Console.ReadLine();
            panel.AddProductToCart(a);
        }
    }

    
}