Console.Clear();
string[] array = {"sdf3", "vin", "1kje", "123", "-234", "kj", "2g", "monday"};
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
string[] b = new string [array.Length];
int j = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length < 4)
    {
        b[j] = array[i];
        Console.Write($"{b[j]} ");
        j++;
    }
}