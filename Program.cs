﻿// See https://aka.ms/new-console-template for more information

string input = "";
Library obj = new Library();
Console.Write("Menu:\n1. Add a book\n2. Borrow a book\n3. Return a book\n4. Exit\n\nSelect an option: ");
while ((input = Console.ReadLine()) != null)
{
    switch (input)
    {
        case "1":
            obj.AddBook();
            break;
        case "2":
            obj.Borrow();
            break;
        case "3":
            obj.Return();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            System.Console.WriteLine("\nUnknown option!");
            break;
    }
    Console.Write("\nMenu:\n1. Add a book\n2. Borrow a book\n3. Return a book\n4. Exit\n\nSelect an option: ");
}
