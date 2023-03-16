
var friends = new Array.Array("Ezhar", "Nursena", "Simba", "Sedi");
friends.SetValue(2, "Ahmet");
Console.WriteLine(friends.GetValue(2));

foreach (var friend in friends)
{
    Console.WriteLine(friend);
}

Console.ReadKey();
