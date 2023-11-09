// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");
//Given an array, find the most frequent element in it. 
//If there are multiple elements that appear a maximum number of times, print any one of them.

//Input : arr[] = { 1, 3, 2, 1, 4, 1 }
//Output : 1
//Explanation: 1 appears three times in array which is maximum frequency.

//Input : arr[] = { 10, 20, 10, 20, 30, 20, 20 }
//Output : 20

//Problem 2: 
//----------

//Check if two arrays are equal or not:

//Given two arrays, arr1 and arr2 of equal length N, the task is to find if the given arrays are equal or not. 
//Two arrays are said to be equal if:
//both of them contain the same set of elements,
//arrangements (or permutations) of elements might/might not be same.
//If there are repetitions, then counts of repeated elements must also be the same for two arrays to be equal.

//Input: arr1[] = { 1, 2, 5, 4, 0 }, arr2[] = { 2, 4, 5, 0, 1 }
//Output: Yes

//Input: arr1[] = { 1, 2, 5, 4, 0, 2, 1 }, arr2[] = { 2, 4, 5, 0, 1, 1, 2 } 
//Output: Yes

//Input: arr1[] = { 1, 7, 1 }, arr2[] = { 7, 7, 1 }
//Output: No

List<int> firstArray = new() { 1, 2, 5, 4, 0, 2, 1 };

List<int> secondArray = new() { 2, 4, 5, 0, 1, 1, 2 };

Dictionary<int, int> matchArray = new Dictionary<int, int>();

Dictionary<int, int> sourceArray = new Dictionary<int, int>();

bool isArrayMatching = true;

foreach (var arr1 in firstArray)
{
    if (matchArray.ContainsKey(arr1))
    {
        sourceArray[arr1] ++;
        continue;
    }
    sourceArray.Add(arr1 , 1 );
    foreach (var arr2 in secondArray)
    {
        if (arr1 == arr2 && !matchArray.ContainsKey(arr2))
        {
            matchArray.Add(arr1, 1);
        }else if (arr1 == arr2 && matchArray.ContainsKey(arr2))
        {
            matchArray[arr1]++;           
        }
       
    }
    if(!matchArray.ContainsKey((int)arr1) )
    {
        isArrayMatching = false;
        Console.WriteLine("Array Matching: " + isArrayMatching) ;
        break;
    }
   
}
foreach(var valuesCheck in matchArray)
{
    if (sourceArray[valuesCheck.Key] != matchArray[valuesCheck.Key])
    {
        isArrayMatching = false;
        Console.WriteLine("Array Matching: " + isArrayMatching); 
    }
}

if (isArrayMatching) { Console.WriteLine("Array Matching: " + true); }


    //ptoblem 1

    int[] elementsCount = { 10, 20, 10, 20, 30, 20, 20 };

int occuranceCount = 0;
int highestOccuranceElement = 0;

Dictionary<int,int> addelements = new();

foreach (int element in elementsCount)
{
    if (addelements.ContainsKey(element))
    {
        addelements[element]++;
     }
    else { addelements.Add(element, 1); }    
}

foreach (var elements in addelements)
{
    if (elements.Value > highestOccuranceElement)
    {
        highestOccuranceElement = elements.Value;
        occuranceCount = elements.Key;
    }
  
}
Console.WriteLine(occuranceCount);
