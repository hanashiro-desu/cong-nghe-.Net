using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_part01
{
    public interface IBook
    {
        string this[int id] { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }
        void Show();
    }

    public class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        private ArrayList chapter = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }


        // constructors
        public Book()
        {
            isbn = "";
            title = "";
            author = "";
            publisher = "";
            year = 0;
            chapter = new ArrayList();
        }
        public Book(string isbn, string title, string author, string publisher, int year)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.chapter = new ArrayList();
        }

        public void Show()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapters: ");
            for (int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            }
            Console.WriteLine("------------------------");
        }

        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();

            Console.Write("Author: ");
            author = Console.ReadLine();

            Console.Write("Publisher: ");
            publisher = Console.ReadLine();

            Console.Write("ISBN: ");
            isbn = Console.ReadLine();

            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapter (finished with empty string):");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);

        }
    }


    public class BookCompareByAuthor : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Book book1 = (Book)x;
            Book book2 = (Book)y;
            return book1.Author.CompareTo(book2.Author);
        }
    }
    public class BookCompareByTitle : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Book book1 = (Book)x;
            Book book2 = (Book)y;
            return book1.Title.CompareTo(book2.Title);
        }
    }

    public class BookCompareByYear : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Book book1 = (Book)x;
            Book book2 = (Book)y;
            return book1.Year.CompareTo(book2.Year);
        }
    }
    public class BookList
    {
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void InputDS()
        {
            int n;
            Console.WriteLine("Input on Amount of books: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                AddBook();
            }
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }
        // Sắp xếp theo tên tác giả
        public void FilterOnAuthor()
        {
            list.Sort(new BookCompareByAuthor());
        }
        // Sắp xếp theo tên sách
        public void FilterOnTitle()
        {
            list.Sort(new BookCompareByTitle());
        }
        // Sắp xếp theo năm xuất bản
        public void FilterOnYear()
        {
            list.Sort(new BookCompareByYear());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();
            bookList.InputDS();

            // Xuất danh sách ban đầu
            Console.WriteLine("\n==========<> ORIGINAL LIST <>==========");
            bookList.ShowList();

            // Sắp xếp theo tên tác giả
            bookList.FilterOnAuthor();
            Console.WriteLine("\n==========<> SORTED BY AUTHOR ( sap xep theo ten tac gia) <>==========");
            bookList.ShowList();

            // Sắp xếp theo tên sách
            bookList.FilterOnTitle();
            Console.WriteLine("\n==========<> SORTED BY TITLE( sap xep theo tieu de sach) <>==========");
            bookList.ShowList();

            // Sắp xếp theo năm xuất bản
            bookList.FilterOnYear();
            Console.WriteLine("\n==========<> SORTED BY YEAR( sap xep theo nam) <>==========");
            bookList.ShowList();
            // doc 
            Console.ReadLine();
        }
    }
}