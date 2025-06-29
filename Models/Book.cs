﻿namespace LibraryManagementSystem.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }

    public List<Borrow> Borrows { get; set; }
}
