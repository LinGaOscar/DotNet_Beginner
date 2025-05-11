// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Oscar!");


string firstFriend = "      Bill     ";
firstFriend = firstFriend.TrimStart();

string secondFriend = "     John     ";
Console.WriteLine($"Hello, {firstFriend} and {secondFriend.Trim()}!");