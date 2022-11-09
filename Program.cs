using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эксперимент 1");
            A A = new A(1);
            B B = new B(2);
            A.b = B;
            B.a = A;
            Console.WriteLine(A.b.PropertyB);
            Console.WriteLine(B.a.PropertyA);
            A.Add(B);
            Console.WriteLine(A.b.PropertyB);
            A4 A4 = new A4(1);
            B4 B4 = new B4(3);
            Console.WriteLine(A4.b.PropertyB4);

            Console.WriteLine();
            Console.WriteLine("Эксперимент 2");
            Bookshelf number1Shelf = new Bookshelf("Полка №1");
            Bookshelf number2Shelf = new Bookshelf("Полка №2");
            List<Book> Nbooks = new List<Book>()
            {
                new Book("'Война и мир'"),
                new Book("'Гарри Поттер'"),
                new Book("'Игра Джеральда'"),
                new Book("'Лето в пионерском галстуке'"),
                new Book("'Колобок'.")
            };

            number1Shelf.books = Nbooks;
            Console.WriteLine(number1Shelf);

            Console.WriteLine();
            Console.WriteLine("Эксперимент 3");
            foreach (Book item in number1Shelf.books)
            {
                item.bookshelf = number1Shelf;
                Console.WriteLine(item.bookshelf);
            }

            Console.WriteLine();
            Console.WriteLine("Эксперимент 4");
            foreach (Book d in Nbooks)
            {
                number2Shelf.Add(d);
            }
            Console.WriteLine(number2Shelf);

            Console.WriteLine();
            Console.WriteLine("Эксперимент 5");
            Bookshelf number3Shelf = new Bookshelf("Полка №3");
            List<Book> tet = new List<Book>();
            number3Shelf.New("'Война и мир'");
            number3Shelf.New("'Гарри Поттер'");
            number3Shelf.New("'Игра Джеральда'");
            Console.WriteLine(number3Shelf);

        }
    }
}
namespace OOP1
{
    class Bookshelf
    {
        public string number { get; set; }
        public List<Book> books { get; set; } = new List<Book>();
        public Bookshelf(string number)
        {
            this.number = number;
        }
        public override string ToString()
        {
            return number + ": " + String.Join(", ", books);
        }
        public void Add(Book d)
        {
            books.Add(d);
        }
        public void New(string book)
        {
            books.Add(new Book(book));
        }
    }
    class Book
    {
        public string book { get; set; }
        public Book(string book)
        {
            this.book = book;
        }
        public override string ToString()
        {
            return book;
        }
        public Bookshelf bookshelf { get; set; }
    }
    class A
    {
        public int PropertyA { get; set; }
        public B b { get; set; }
        public A(int PropertyA)
        {
            this.PropertyA = PropertyA;
        }
        public void Add(B d)
        {
            b = d;
        }

    }
    class B
    {
        public int PropertyB { get; set; }
        public A a { get; set; }
        public B(int PropertyB)
        {
            this.PropertyB = PropertyB;
        }
    }
    class A4
    {
        public int PropertyA4 { get; set; }
        public B4 b { get; set; }
        public A4(int propertya)
        {
            PropertyA4 = propertya;
            b = new B4(3);
        }
    }
    class B4
    {
        public int PropertyB4 { get; set; }
        public A4 a { get; set; }
        public B4(int propertyb)
        {
            PropertyB4 = propertyb;
        }
    }
}