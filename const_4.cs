//create a class book having member variables bookid , title, author, and price 
//and a method getdata() with no parameters , create another overloaded method getdata() with 4 parameters

using System;

namespace const_4
{
    class book
    {
        int bookid, price;
        string title, author;

       public void getdata()
        {
            bookid = 10;
            title = "gyan";
            author = "sadhubaba";
            price = 150;
        }
        public void getdata(int bookid,string title,string author,int price)
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
        class program
        {
            public static void Main()
            {
                Console.WriteLine("---------Book Details---------");
                book book = new book();
                book.getdata();
                book.display();
                Console.WriteLine("---------Book Details---------");
                book book1 = new book();
                book1.getdata(20, "info", "patanahi", 00);
                book1.display();
                Console.WriteLine("---------Book Details---------");
                book book2 = new book();
                Console.WriteLine("Enter Book Id :");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Book Title :");
                string title =Console.ReadLine();
                Console.WriteLine("Enter Book Author :");
                string author = Console.ReadLine();
                Console.WriteLine("Enter Book Price :");
                int price = Convert.ToInt32(Console.ReadLine());
                book2.getdata();

                book2.display();


            }
        }
    }
}