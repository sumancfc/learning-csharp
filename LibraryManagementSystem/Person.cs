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
// public class Member : Person
// {
//     public string MemberId { get; set; }
//     public List<LibraryItem> BorrowedItems { get; set; }
// }