string message = "Hello, World!";

object boxed = "this is a string at runtime";

IEnumerable<char> characters = "abcdefghijklmnopqrstuvwxyz1234567890";
Random random = new Random();
string randomString = new string(Enumerable.Range(0, 10).Select(_ => characters.ElementAt(random.Next(characters.Count()))).ToArray());
Console.WriteLine(randomString);