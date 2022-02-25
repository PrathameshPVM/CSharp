using System;

namespace const_1
{
    public class Program
    {
        class book
        {
            int bookid;
            string title,author;
            int price;
            public book()
            {
                bookid = 1;
                title = ".Net";
                author = "Raju";
                price = 150;
            }
            public void display()
            {
                Console.WriteLine("book id = " + bookid);
                Console.WriteLine("book title = " + title);
                Console.WriteLine("book author= " + author);
                Console.WriteLine("price = " + price);


            }

        }
        public static void Main (String[] args)
        {
            book book = new book();
            book.display();
            Console.ReadLine();
        }
    }
}