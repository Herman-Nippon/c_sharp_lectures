Console.Write("Enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "herman")
{
    Console.WriteLine("Hello, mate, how's it going?");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
