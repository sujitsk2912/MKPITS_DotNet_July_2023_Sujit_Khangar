using system;

namespace Library
{
    class Author{
        public string Author{ get; set;}

        public Author(string Author)
        {
            this.Author = Author;
        }
    }

    class Book{
        public string Title {get; set;}
        public int ISBN { get; set;}
        public Author BookAuthorName;

        public Book(string Title, int ISBN, Author BookAuthorName)
        {
            this.Title = Title;
            this.ISBN = ISBN;
            Author = BookAuthorName;
        }
    }

    class Library
    {
        list<Book> books = new list<Book>;

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(book)
    }
}