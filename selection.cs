using system;
class ABC{
  static void sort(int []arr)
{
int n= arr.Length;
 //Move boundary of unstorted one by one 
for(int i =0; i< n -1 ;i++)
{
int min_idx = i;
for (int j=i+1 ; j<n ; j++)
  if(arr[j] < arr[min_idx])
        min_idx = j;

int temp=arr[min_idx];
arr[min_idx] = arr[i];
arr[i] = temp;
}
}
//print array
static void printArray(int [] arr)
{
int n = arr.Length;
for(int i =0;i<n; ++i)
 Console.Write(arr[i]+ " ");
Console.WriteLine();
}
//driver code
public static void Main(){
int [] arr = {64,25,12,22,11};
sort(arr);
Console.WriteLine("Sorted array");
printArray(arr);
}
}
