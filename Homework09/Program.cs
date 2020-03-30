using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;

namespace Homework09
{
class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader(@"product.csv"))
            {
                List<string> SKU = new List<string>();
                List<string> Name = new List<string>();
                List<string> Price = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    SKU.Add(values[0]);
                    Name.Add(values[1]);
                    Price.Add(values[2]);
                }
                Console.WriteLine("Products in your cart are");
                Console.WriteLine("none");
                Console.WriteLine("----------");
                Console.WriteLine("Total amount: 0.00 Bath");

                ArrayList Product = new ArrayList();
                int sum = 0 ;

                do{
                    Console.WriteLine("Please input a product key :");
                    string input = Console.ReadLine();
                    for (int i = 0 ; i < SKU.Count; i++ ) {
                        if ( SKU[i] == input ){
                            string a = Price[i];
                            int b = Convert.ToInt32(a);
                            sum += b;
                            Product.Add(Name[i] + "  " + a);

                        }
                      
                    }
                
                    Console.WriteLine("Products in your cart are");
                    for (int i = 1  ; i <= Product.Count; i++){
                        int Number = Convert.ToInt32(i);
                        int Order = Number - 1;

                        Console.WriteLine(Number + ". " + Product[Order]);
                    }
          
                    Console.WriteLine("----------");
                    Console.WriteLine("Total amount: " + sum + " Bath");

                } while (true);
                
            
            }
        }
    }
}




