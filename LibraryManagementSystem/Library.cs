using System;
using System.Collections;
using System.Linq;

namespace learningCSharp.LibraryManagementSystem;

public class Library
{
    private List<LibraryItem> _items;

    public Library()
    {
        _items = new List<LibraryItem>();
    }

    public void AddItem(LibraryItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(string isbn)
    {
        _items = _items.Where(item => item.ISBN != isbn).ToList();
    }

    public List<LibraryItem> FindItem(string searchTerm, string searchBy = "title")
    {
        searchTerm = searchTerm.ToLower();

        return _items.Where(item =>
        {
            switch (searchBy.ToLower())
            {
                case "title": return item.Title.ToLower().Contains(searchTerm);
                case "author": return item.Author.ToLower().Contains(searchTerm);
                case "isbn": return item.ISBN == searchTerm;
                default: return false;
            }
        }).ToList();
    }

    public void DisplayItems()
    {
        foreach (LibraryItem item in _items)
        {
            Console.WriteLine(item);
        }
    }
}