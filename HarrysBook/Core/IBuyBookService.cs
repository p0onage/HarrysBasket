using System.Collections.Generic;
using HarrysBook.Models;

namespace HarrysBook.Core
{
    public interface IBuyBookService
    {
        bool BuyBook(int bookId, int quantity);
        IEnumerable<Book> GetBasketList();
        decimal GetBasketTotal();
    }
}