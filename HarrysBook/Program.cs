using System;
using System.Collections.Generic;
using System.Linq;
using HarrysBook.Core;
using HarrysBook.DataStore;
using HarrysBook.Models;

namespace HarrysBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buying Books!");
            var buyBookService = new BuyBookService(BookStore.Return_Book_Store());
            buyBookService.BuyBook(1,1);
            buyBookService.BuyBook(2,1);
            buyBookService.BuyBook(3,1);
            
            Console.WriteLine($"Price of books is a total of : {buyBookService.GetBasketTotal()}");
            Console.ReadLine();
        }
    }
}