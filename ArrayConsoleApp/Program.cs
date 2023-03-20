
Array.Array array = new Array.Array();

array.Add("Ezhar");
array.Add("Shams");
array.Add("Shahid");

Console.WriteLine($"Array length before adding 4th : {array.Length}");
array.Add("Omer");
Console.WriteLine($"Array length after adding 4th : {array.Length}");
array.Add("Nur");
array.Add("Ehsan");
array.Add("Sidi");
array.Add("Bek");
Console.WriteLine($"Array length after adding 8th : {array.Length}");


/*

void Add(string item)
{
	names[Counter] = item;
	Counter++;

	if (Counter == names.Length)
	{
		DoubleArray(names);
	}
}
*/

/*void DoubleArray(string[] arr)
{
    string[] tempArr = new string[arr.Length * 2];
	

	for (int i = 0; i < arr.Length; i++)
	{
		tempArr[i] = arr[i];	
	}

	names = tempArr;


}
*/



Console.ReadKey();


