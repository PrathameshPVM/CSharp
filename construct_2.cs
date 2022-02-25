using System;

namespace construct_2
{
    class book
    {
        int bookid;
        string title, author;
        int price;
        public book()
        {
            bookid = 1;
            title = ".Net";
            author = "Raju";
            price = 150;
        }
        public book(int bookid, string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }
    }

    class program
    {
        public static void Main(String[] args)
        {
            book b = new book();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            book b1 = new book(111, "csharp", "martin", 2000);
            b1.display();
            Console.WriteLine("-----------------book1 details ----------");
            Console.WriteLine("enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            String title = Console.ReadLine();
            Console.WriteLine("enter author");
            String author = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------book2 details ----------");
            book b2 = new book(id, title, author, price);
            b2.display();

            Console.ReadLine();

        }
    }

}