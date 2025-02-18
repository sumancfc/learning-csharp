using System;
using System.Collections;
using System.Linq;

namespace learningCSharp.LibraryManagementSystem;

public class Library
{
    private List<LibraryItem> _items;
    private List<Member> _members;

    public Library()
    {
        _items = new List<LibraryItem>();
        _members = new List<Member>();
    }

    public void AddItem(LibraryItem item)
    {
        _items.Add(item);
    }

    public void RemoveItem(string isbn)
    {
        _items = _items.Where(item => item.ISBN != isbn).ToList();
    }

    public void AddMember(Member member)
    {
        _members.Add(member);
    }

    public void RemoveMember(string memberId)
    {
        _members = _members.Where(member => member.MemberId != memberId).ToList();
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

    public List<Member> FindMember(string searchTerm, string searchBy = "name")
    {
        searchTerm = searchTerm.ToLower();

        return _members.Where(member =>
        {
            switch (searchBy.ToLower())
            {
                case "name": return member.Name.ToLower().Contains(searchTerm);
                case "id": return member.MemberId == searchTerm;
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

    public void DisplayMembers()
    {
        foreach (Member member in _members)
        {
            Console.WriteLine($"Name: {member.Name}, ID: {member.MemberId}");
        }
    }
}