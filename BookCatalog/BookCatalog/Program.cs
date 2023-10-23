using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog
{
    class Program
    {
        static Dictionary<string, Book> catalog = new Dictionary<string, Book>(StringComparer.OrdinalIgnoreCase);
        static void Main(string[] args)
        {
            String opt;
            do {
                Console.WriteLine("Welcome to the Library Catalog System!\n1.Add a book\n2.Search for books\n3.Display catalog\n4.Exit\n\nEnter your choice:");
                int choice =int.Parse( Console.ReadLine());
                switch (choice) {
                    case 1:
                        add();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        display();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("If you want to Continue(y/n):");
                opt = Console.ReadLine();
            } while (opt=="y");
        }
        public static void add() {
            Console.Write("Enter the title of the book:");
            String title = Console.ReadLine();
            Console.Write("Enter the author of the book:");
            String author= Console.ReadLine();
            Console.Write("Enter the publication year of the book:");
            int year = int.Parse(Console.ReadLine());
            if (!catalog.ContainsKey(title))
            {
                Book book = new Book() { Title = title, Author = author, Publication = year };
                catalog.Add(title, book);
                Console.WriteLine("Book added to the catalog!");
            }
            else {
                Console.WriteLine("The book has already been there.....!");
            }
        }

        public static void search() {
            Console.WriteLine("1. Search by title\n2.Search by author");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter the Title to search for:");
                string title = Console.ReadLine();
                //string low = title.ToLower();
                foreach (string key in catalog.Keys) {
                    if (key.Contains(title.ToLower())|| key.Contains(title.ToUpper())) {
                        Book book = catalog[key];
                        Console.WriteLine("Book Found:\nTitle:" + key + "\nAuthor:" + book.Author + "\nPublication year:" + book.Publication);
                    }
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the Author to search for:");
                String author = Console.ReadLine();
                foreach (KeyValuePair<string, Book> kvp in catalog)
                {
                    if (kvp.Value.Author==author.ToUpper()|| kvp.Value.Author == author.ToLower()) {
                        Console.WriteLine("Book Found:\nTitle:" + kvp.Key + "\nAuthor:" + kvp.Value.Author + "\nPublication year:" + kvp.Value.Publication);
                    }
                }

            }
            else {
                Console.WriteLine("Invalid Choice.....");
            }
        }
        public static void display() {
            Console.WriteLine("Current Catalog:");
            foreach (KeyValuePair<String,Book> kvp in catalog) {
                Console.WriteLine(kvp.Key+" by "+kvp.Value.Author+" ("+kvp.Value.Publication+")");
            }
        }
    }
}
