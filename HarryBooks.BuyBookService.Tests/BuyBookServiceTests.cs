using HarrysBook.DataStore;
using HarrysBook.Models;
using NUnit.Framework;

namespace HarryBooks.BuyBookService.Tests
{
    public class BuyBookServiceTests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        
        [Test]
        public void The_Total_Cost_Of_Books_Should_Be_()
        {
            var BuyBookService = new HarrysBook.Core.BuyBookService(BookStore.Return_Book_Store());
            
            BuyBookService.BuyBook(1,1);
            BuyBookService.BuyBook(2,1);
            BuyBookService.BuyBook(3,1);
            var basketTotal  = BuyBookService.GetBasketTotal();
            Assert.AreEqual(basketTotal, 24);
        }
    }
}