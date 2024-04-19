int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
//или так while (i < n)
{
    arr[i] = i + 1;
    //console.Write(arr[i]);
    //Console.WriteLine(' ');
    Console.Write($"{arr[i]}");
    i = i + 1;
}
