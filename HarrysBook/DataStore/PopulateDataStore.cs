using System.Collections.Generic;
using HarrysBook.Models;

namespace HarrysBook.DataStore
{
    public static class BookStore
    {    
        public static List<Book> Return_Book_Store()
        {
            return new List<Book>()
            {
                new Book() { id = 1, title = "Harry's Book One", price = 8, currencyType = Currency.EUR },
                new Book() { id = 2, title = "Harry's Book Two", price = 8, currencyType = Currency.EUR },
                new Book() { id = 3, title = "Harry's Book Three", price = 8, currencyType = Currency.EUR }
            };
        }
    }
}