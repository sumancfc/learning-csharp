namespace learningCSharp.LibraryManagementSystem;

// Inheritance: Book inherits from LibraryItem
public class Book : LibraryItem
{
    public string Genre{ get; set; }

    public Book(string title, string author, string isbn, int publicationYear, string genre): base(title,  author,  isbn, publicationYear)
    {
        Genre = genre;
    }

    public override string GetDetails()
    {
        return $"Book: Title: {Title}, Author: {Author}, ISBN: {ISBN}, Genre: {Genre}";
    }
}