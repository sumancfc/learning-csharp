using System;
using System.Collections.Generic;
using System.Linq;

namespace learningCSharp.LibraryManagementSystem;

public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactInfo { get; set; }

    public Person(string name, string address, string contactInfo)
    {
        Name = name;
        Address = address;
        ContactInfo = contactInfo;
    }
}

// Derived Class
public class Member : Person
{
    public string MemberId { get; set; }
    public List<LibraryItem> BorrowedItems { get; set; }

    public Member(string name, string address, string contactInfo, string memberId) : base(name, address, contactInfo)
    {
        MemberId = memberId;
        BorrowedItems = new List<LibraryItem>();
    }

    public void BorrowItem(LibraryItem item)
    {
        if (!item.IsBorrowed)
        {
            BorrowedItems.Add(item);
            item.IsBorrowed = true;
            Console.WriteLine($"{Name} borrowed: {item.Title}");
        }
        else
        {
            Console.WriteLine($"{item.Title} is already borrowed.");
        }
    }

    public void ReturnItem(LibraryItem item)
    {
        if (BorrowedItems.Contains(item))
        {
            BorrowedItems.Remove(item);
            item.IsBorrowed = false;
            Console.WriteLine($"{Name} returned: {item.Title}");
        }
        else
        {
            Console.WriteLine($"{Name} did not borrow {item.Title}");
        }
    }
}