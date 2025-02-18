namespace learningCSharp.LibraryManagementSystem;

// Abstraction: Abstract base class for Library Items
public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public bool IsBorrowed { get; set; }

    public LibraryItem(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
        IsBorrowed = false;
    }

    public abstract string GetDetails();
    public override string ToString() => GetDetails();
}