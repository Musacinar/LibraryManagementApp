using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManagementSystem librarySystem = new LibraryManagementSystem();

            bool showMenu = true;
            while (showMenu)
            {
                Console.WriteLine("Kütüphane Yönetim Sistemine Hoş Geldiniz!");
                Console.WriteLine("1. Kitap Ekle");
                Console.WriteLine("2. Kitap Sil");
                Console.WriteLine("3. Kitap Güncelle");
                Console.WriteLine("4. Üye Ekle");
                Console.WriteLine("5. Tüm Kitapları Listele");
                Console.WriteLine("6. Tüm Üyeleri Listele");
                Console.WriteLine("7. Üye Sil");
                Console.WriteLine("8. Kitabı Üyeye Tanımla");
                Console.WriteLine("9. Üyedeki Kitaplar");
                Console.WriteLine("10. Çıkış");



                Console.Write("Seçiminizi yapınız: ");
                int choice = Convert.ToInt32(Console.ReadLine());


               


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke3 = Console.ReadKey();
                        if (ke3.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke3.KeyChar == '2')
                        {
                            Console.Write("\nKitap ID: ");
                            int bookId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Kitap Adı: ");
                            string title = Console.ReadLine();
                            Console.Write("Yazar Adı: ");
                            string author = Console.ReadLine();
                            Console.Write("Miktar: ");
                            int quantity = Convert.ToInt32(Console.ReadLine());

                            librarySystem.AddBook(new Book { Id = bookId, Title = title, Author = author });
                        }

                        break;
                    case 2:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke2 = Console.ReadKey();
                        if (ke2.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke2.KeyChar == '2')
                        {
                            Console.Write("\nSilmek istediğiniz kitabın ID'sini giriniz: ");
                            int deleteBookId = Convert.ToInt32(Console.ReadLine());
                            librarySystem.RemoveBook(deleteBookId);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke1 = Console.ReadKey();
                        if (ke1.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke1.KeyChar == '2')
                        {
                            Console.Write("\nGüncellemek istediğiniz kitabın ID'sini giriniz:\n ");
                            int updateBookId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yeni Kitap Adı: ");
                            string newTitle = Console.ReadLine();
                            Console.Write("Yeni Yazar Adı: ");
                            string newAuthor = Console.ReadLine();
                            Console.Write("Yeni Miktar: ");
                            int newQuantity = Convert.ToInt32(Console.ReadLine());


                            librarySystem.UpdateBook(new Book { Id = updateBookId, Title = newTitle, Author = newAuthor });
                        }
                            break;
                    case 4:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke = Console.ReadKey();
                        if (ke.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke.KeyChar == '2')
                        {
                            Console.WriteLine("\n");

                            Console.Write("Üye ID: ");
                            int MemberId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Üye Adı: ");
                            string memberName = Console.ReadLine();
                            Console.Write("Telefon Numarası: ");
                            string memberPhone = Console.ReadLine();

                          librarySystem.AddMember(new Member { Id = MemberId, Name = memberName, PhoneNumber = memberPhone });

                        }
                     
                        break;
                    case 5:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'\n");
                        ConsoleKeyInfo ke4 = Console.ReadKey();
                        if (ke4.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke4.KeyChar == '2')
                        {

                            librarySystem.ListAllBooks();
                        }
                        
                        break;
                    case 6:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke5 = Console.ReadKey();
                        if (ke5.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke5.KeyChar == '2')
                        {
                            librarySystem.ListAllMembers();
                        }
                        break;
                   
                    case 7:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke6 = Console.ReadKey();
                        if (ke6.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke6.KeyChar == '2')
                        {
                            Console.Write("\nSilmek istediğiniz üye ID'sini giriniz: ");
                            int deletememberid = Convert.ToInt32(Console.ReadLine());
                            librarySystem.RemoveMember(deletememberid);
                        }
                        break;

                    case 8:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke7 = Console.ReadKey();
                        if (ke7.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke7.KeyChar == '2')
                        {
                            Console.Write("\nÜye ID: ");
                            int memberId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Kitap ID: ");
                            int book; 
                            int.TryParse(Console.ReadLine(), out book); 
                            Console.Write("Gün Sayısı: ");
                            int days = Convert.ToInt32(Console.ReadLine());

                            librarySystem.BorrowBook(memberId, book, days);
                        }
                        break;

                    case 10:
                        Console.WriteLine("\nAna menüye dönmek için '1' tuşuna basın devam etmek için '2'");
                        ConsoleKeyInfo ke8 = Console.ReadKey();
                        if (ke8.KeyChar == '1')
                        {
                            showMenu = true;
                        }
                        else if (ke8.KeyChar == '2')
                        {
                            showMenu = false;
                            Console.WriteLine("\nÇıkış yapılıyor");
                        }
                        break;

                    case 9:
                        librarySystem.ListBorrowedBooks();
                        break;



                    default:
                        Console.WriteLine("Geçersiz seçenek! Tekrar deneyin.");
                        break;

                }


              

                Console.ReadKey();
                Console.Clear();
            }
        
        }
    }
}

