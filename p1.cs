using System.Runtime.InteropServices;

int[] arr={1,2,3,4,5,6,7};
string res=string.Join("",arr);
Console.WriteLine(res);

int k = 3;
k=k%arr.Length;

Array.Reverse(arr);
Array.Reverse(arr, 0, k);
Array.Reverse(arr, k, arr.Length-k);
Console.WriteLine(string.Join("",arr));