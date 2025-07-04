using LibraryManagementSystem.Services;

var bookService = new BookService();
var MemberService = new MemberService();
var BorrowService = new BorrowService();

try
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("**** Library Management System ****");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. List Book");
        Console.WriteLine("3. Add Member");
        Console.WriteLine("4. List Member");
        Console.WriteLine("5. Borrow Book");
        Console.WriteLine("6. Return Book");
        Console.WriteLine("7. List All Borrows");
        Console.WriteLine("0. Exit");
        Console.WriteLine("\nSelect an Option: ");
        var input = int.Parse(Console.ReadLine());

        Console.Clear();

        switch (input)
        {
            case 1:
                bookService.AddBook();
                break;
            case 2:
                bookService.ListBook();
                break;
            case 3:
                MemberService.AddMember();
                break;
            case 4:
                MemberService.ListMember();
                break;
            case 5:
                BorrowService.BorrowBook();
                break;
            case 6:
                BorrowService.ReturnBook();
                break;
            case 7:
                BorrowService.ListAllBorrows();
                break;
            case 0:
                Console.WriteLine("Exiting...");
                return;
            default: Console.WriteLine("Invaild Option!"); break;
        }
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Invalid Input!");
    return;
}


