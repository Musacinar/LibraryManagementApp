using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApp
{
    public class BorrowedBook
    {
        public Member Member { get; set; }
        public Book Book { get; set; }
        public int Days { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; } 


        public BorrowedBook(Member member, Book book, int days)
        {
            Member = member;
            Book = book;
            Days = days;
            BorrowDate = DateTime.Now;
        }
        public void ReturnBook()
        {
            ReturnDate = DateTime.Now;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Üye: {Member.Name}, Kitap: {Book.Title}, Ödünç Alma Tarihi: {BorrowDate}, Ödünç Alma Süresi: {Days} gün");
        }
    }


}
