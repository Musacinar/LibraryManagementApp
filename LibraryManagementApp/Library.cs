using LibraryManagementApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Contexts;
using System.Data;
using System.Net.Configuration;

public class LibraryManagementSystem
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();


    SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog = Library; Integrated Security = true");


    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Kitap başarıyla eklendi.");
    }

    public void RemoveBook(int bookId)
    {
        Book bookToRemove = books.Find(book => book.Id == bookId);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Kitap başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }

    public void RemoveMember(int bookId)
    {
        Member memberToRemove = members.Find(member => member.Id == member.Id);
        if (memberToRemove != null)
        {
            members.Remove(memberToRemove);
            Console.WriteLine("Üye başarıyla silindi.");
        }
        else
        {
            Console.WriteLine("Üye bulunamadı.");
        }
    }







    public void UpdateBook(Book updatedBook)
    {
        Book bookToUpdate = books.Find(book => book.Id == updatedBook.Id);
        if (bookToUpdate != null)
        {
            bookToUpdate.Title = updatedBook.Title;
            bookToUpdate.Author = updatedBook.Author;
            Console.WriteLine("Kitap bilgileri başarıyla güncellendi.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }

    public void AddMember(Member member)
    {
        members.Add(member);
        Console.WriteLine("Üye başarıyla eklendi.");
    }

    public void ListAllBooks()
    {
        Console.WriteLine("\nTüm Kitaplar:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Ad: {book.Title}, Yazar: {book.Author}");
        }
    }

    public void ListAllMembers()
    {
        Console.WriteLine("\nTüm Üyeler:");
        foreach (var member in members)
        {
            Console.WriteLine($"ID: {member.Id}, Ad: {member.Name},  Telefon: {member.PhoneNumber}");
        }
    }

    public void BorrowBook(int memberId, int bookId, int days)
    {
        Member member = members.Find(m => m.Id == memberId);
        Book book = books.Find(b => b.Id == bookId);

        if (member == null)
        {
            Console.WriteLine("Üye bulunamadı.");
            return;
        }

        if (book == null)
        {
            Console.WriteLine("Kitap bulunamadı.");
            return;
        }
        if (days > 30)
        {
            Console.WriteLine("Kitabı en fazla 30 gün içinde teslim etmeniz gerekmektedir");
            return;
        }
        
        BorrowedBook borrowedBook = new BorrowedBook(member, book, days);
        borrowedBooks.Add(borrowedBook);

        Console.WriteLine($" {book.Title} kitabını {memberId} Idli kullanıcı {days} gün boyunca ödünç alındı.");

       
    }
    public void ListBorrowedBooks()
    {
        foreach (var borrowedBook in borrowedBooks)
        {
            borrowedBook.PrintDetails();
        }
    }

    private List<BorrowedBook> borrowedBooks; 

    public LibraryManagementSystem()
    {
        borrowedBooks = new List<BorrowedBook>(); 
    }


}



/*

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryManagementApp
{
    public class LibraryManagementSystem
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();
        private string connectionString = @"server=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=true";

        public void AddBook(Book book)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Book (Id, Title, Author) VALUES (@Id, @Title, @Author)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", book.Id);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@Author", book.Author);
                // command.Parameters.AddWithValue("@Publisher", book.Publisher);




                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Kitap başarıyla eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Kitap eklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        public void RemoveBook(int bookId)
        {
        }

        public void UpdateBook(Book updatedBook)
        {
        }

        public void AddMember(Member member)
        {
        }

        public void RemoveMember(int memberId)
        {
        }

        public void ListAllBooks()
        {
            Console.WriteLine("Tüm Kitaplar:");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Ad: {book.Title}, Yazar: {book.Author}");
            }
        }

        public void ListAllMembers(Member member)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Book (Id, NAme, PhoneNumber) VALUES (@Id, @Name, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", member.Id);
                command.Parameters.AddWithValue("@Title", member.Name);
                command.Parameters.AddWithValue("@Author", member.PhoneNumber);
              
                    connection.Open();





                } }
    }
}
*/