using HW_1;
using System;
using System.Collections;

ArrayList books = new ArrayList();
while (true)
{
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Display book list");
    Console.WriteLine("3. Search book by author");
    Console.WriteLine("4. Remove book");
    Console.WriteLine("5. Exit");
    int option = int.Parse(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter book year: ");
            int year = int.Parse(Console.ReadLine());
            Book book = new Book { Title = title, Author = author, Year = year };
            books.Add(book);
            Console.WriteLine("Book added successfully!");
            break;
        case 2:
            if (books.Count == 0)
            {
                Console.WriteLine("The library has no books.");
            }
            else
            {
                Console.WriteLine("Book list:");
                int i = 0;
                foreach (Book b in books)
                {
                    Console.WriteLine($"Index: {i}, Title: {b.Title}, Author: {b.Author}, Year: {b.Year}");
                    i++;
                }
            }
            break;
        case 3:
            Console.Write("Enter author name: ");
            string authorName = Console.ReadLine();
            bool found = false;
            Console.WriteLine($"Books by {authorName}:");
            foreach (Book b in books)
            {
                if (b.Author == authorName)
                {
                    Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Year: {b.Year}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("There are no books with this author");
            }
            break;
        case 4:
            Console.Write("Enter book index to remove: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < books.Count)
            {
                books.RemoveAt(index);
                Console.WriteLine("Book removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
            break;
        case 5:
            Console.WriteLine("Exiting program...");
            return;
        default:
            Console.WriteLine("Invalid option!");
            break;
    }
}
