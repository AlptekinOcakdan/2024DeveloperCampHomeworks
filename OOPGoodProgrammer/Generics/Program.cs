using Generics;

List<string> cities1 = ["New York", "London", "Paris"];

Console.WriteLine(cities1.Count);

MyList<string> cities2 = new MyList<string>();

cities2.Add("New York");
cities2.Add("London");

Console.WriteLine(cities2.Count);