﻿
Console.WriteLine("Enter the number of array elements: ");
int size  = int.Parse(Console.ReadLine());

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Enter an array element: ");
    string result = Console.ReadLine();
	arr1[i] = result;  
}
Console.WriteLine();
Console.Write("The entered array: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int maxSymbols = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= maxSymbols){
		count++;
	}   
}
Console.WriteLine();
Console.Write("The resulting array: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxSymbols){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + ",");
        j++;
    }
}
Console.Write("]");