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

// 2. Inheritance: DVD inherits from LibraryItem
public class DVD : LibraryItem
{
    public int Duration { get; set; } // Duration in minutes

    public DVD(string title, string author, string isbn, int publicationYear, int duration)
            : base(title, author, isbn, publicationYear)
    {
        Duration = duration;
    }

    public override string GetDetails()
    {
        return $"DVD: Title: {Title}, Author: {Author}, ISBN: {ISBN}, Duration: {Duration} min";
    }
}
