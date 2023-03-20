

string[] _array = new string[3] { "Ezhar", "Shams", "Shahid" };
string[] new_array = new string[4];
Console.WriteLine(_array.Length);
new_array[0] = _array[0];
new_array[1] = _array[1];
new_array[2] = _array[2];
_array = new_array;
_array[3] = "sidi";
Console.WriteLine(_array.Length);

static void DoubleArray(string[] arr)
{
    string[] tempArr = new string[arr.Length * 2];
}



Console.ReadKey();


