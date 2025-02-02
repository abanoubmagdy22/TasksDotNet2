namespace SolveTaskDay5Oop
{

    class Book
    {
        //string title;
        //string author;
        //string isbn;
        //bool availability;

        public string Title { get; set; }

        public string Author { get; set; }
        public string Isbn { get; set; }
        public bool Availability { get; set; }

        public Book(string title, string author, string isbn, bool availability = true)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Availability = availability;
        }
    }

    class Library
    {
        List<Book> books;
        public Library()
        {
            books = new List<Book>();

        }
        //Add book
        public void AddBook(Book book)
        {
            if (books != null)
            {
                books.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the library.");
            }
        }
        //search for book
        public Book SearchBook(string searchBook)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if(books[i].Title == searchBook || books[i].Author == searchBook)
                {
                    return books[i];
                }
            }
            return null;



        }


        //borrow book
        public void BorrowBook(string searchTerm)
        {
            Book book = SearchBook(searchTerm);
            if (book != null)
            {
                if (book.Availability)
                {
                    book.Availability = false;
                    Console.WriteLine($"this book '{book.Title}' was borrowed by {book.Author}.");
                }
                else
                {
                    Console.WriteLine($"Sorry, '{book.Title}' is already borrowed.");
                }
            }
            else
            {
                Console.WriteLine($"Book  '{searchTerm}' not found in the library.");
            }
        }

        public void ReturnBook(string searchTerm)
        {
            Book book = SearchBook(searchTerm);
            if (book != null)
            {
                if (!book.Availability)
                {
                    book.Availability = true;
                    Console.WriteLine($"You returned '{book.Title}'.");
                }
                else
                {
                    Console.WriteLine($"'{book.Title}' was not borrowed.");
                }
            }
            else
            {
                Console.WriteLine($"Book matching '{searchTerm}' not found in the library.");
            }
        }


    }


    internal class Program
        {
            static void Main(string[] args)
            {
                //Console.WriteLine("Hello, World!");
                Library library = new Library();

                // Adding books to the library
                library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

                // Searching and borrowing books
                Console.WriteLine("\nSearching and borrowing books...");
                library.BorrowBook("Gatsby");
                library.BorrowBook("1984");
                library.BorrowBook("Harry Potter");

                // Returning books
                Console.WriteLine("\nReturning books...");
                library.ReturnBook("Gatsby");
                library.ReturnBook("Harry Potter"); 

                Console.ReadLine();
            }
        }
    
}
