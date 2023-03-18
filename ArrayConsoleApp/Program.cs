


Array.Array newArray = new Array.Array(12,32,54,43,56,8,65,54);
for (int i = 0; i < newArray.Length; i++)
{
    newArray.SetValue(i, i*2+2);
}
for(int i = 0; i < newArray.Length; i++)
{
    Console.WriteLine(newArray.GetValue(i));
}

//Console.WriteLine(newArray.GetValue(2));




Console.ReadKey();


