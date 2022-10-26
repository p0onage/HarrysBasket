using System.Collections.Generic;
using System.Linq;
using HarrysBook.DataStore;
using HarrysBook.Models;

namespace HarrysBook.Core
{
    public class BuyBookService : IBuyBookService
    {
        private readonly List<Book> _bookCollection;
        private readonly List<Book> _bookBasket = new List<Book>();

        public BuyBookService(List<Book> bookCollection)
        {
            _bookCollection = bookCollection;
        }
        public bool BuyBook(int bookId, int quantity)
        {
            var book = _bookCollection.SingleOrDefault(x => x.id == bookId);
            if (book != null)
            { 
                _bookBasket.Add(_bookCollection.Single(x => x.id == bookId));
                return true;
            }

            return false;
        }

        public decimal GetBasketTotal() => GetBasketList().Sum(x => x.price);

        public IEnumerable<Book> GetBasketList() => _bookCollection;
    }
}