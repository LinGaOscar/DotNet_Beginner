// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Oscar!");


string firstFriend = "Bill";
string secondFriend = "John";
string friends = $"Hello, {firstFriend} and {secondFriend}!";

Console.WriteLine(friends);
friends = friends.Replace("John", "Oscar");
Console.WriteLine(friends);