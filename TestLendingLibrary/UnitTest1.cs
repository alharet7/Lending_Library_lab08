using System;
using Xunit;
using LendingLibrary;

namespace TestLendingLibrary
{
    public class UnitTest1
    {
        //Add a Book to your Library
        [Fact]
        public void AddABookToYourLibrary()
        {
            Library PhilesLibrary = new Library();
            PhilesLibrary.Add("Vahana Masterclass", "Alfredo", "Covelli", 290);

            Assert.Single(PhilesLibrary);
        }

        //Borrowing an existing title returns the Book 
        [Fact]
        public void BorrowingAnExistingTitleReturnsTheBook()
        {
            Library PhilesLibrary = new Library();
            PhilesLibrary.Add("Vahana Masterclass", "Alfredo", "Covelli", 290);
            PhilesLibrary.Borrow("Vahana Masterclass");
            Assert.Empty(PhilesLibrary);
        }

        //Borrowing a missing title returns null
        [Fact]
        public void BorrowingAMissingTitleReturnsNull()
        {
            Library PhilesLibrary = new Library();
            PhilesLibrary.Add("Vahana Masterclass", "Alfredo", "Covelli", 290);
            Assert.Null(PhilesLibrary.Borrow("A"));
        }

        //Returned book is once again in the Library
        [Fact]
        public void ReturnedBookIsOnceAgainInTheLibrary()
        {
            Library PhilesLibrary = new Library();
            PhilesLibrary.Add("Vahana Masterclass", "Alfredo", "Covelli", 290);
            Book book = new Book("Vahana Masterclass", "Alfredo", "Covelli", 290);

            Assert.Null(PhilesLibrary.Borrow("A"));
        }

        //Pack and Unpack your Backpack
        [Fact]
        public void PackAndUnpackYourBackpack()
        {
            Backpack<int> backpack = new Backpack<int>();
            backpack.Pack(1);
            Assert.Equal(1, backpack.Unpack(0));
        }
    }
}