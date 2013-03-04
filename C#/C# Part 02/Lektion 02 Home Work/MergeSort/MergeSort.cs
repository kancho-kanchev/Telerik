using System;
using System.Collections.Generic;

//13.* Write a program that sorts an array of integers
//using the merge sort algorithm (find it in Wikipedia)

internal class MergeSort
{
	private static List<int> mergeSort(List<int> list)
	{
		//consider it sorted and return it
		// (using less than or equal prevents infinite recursion for a zero length m)
		if (list.Count <= 1)
		{
			return list;
		}
		else //so split the list into two sublists
		{
			//	var list left, right
			List<int> listLeft = new List<int>();
			List<int> listRight = new List<int>();
			int middle = list.Count / 2;

			//for each x in m before middle
			//	 add x to left
			//for each x in m after or equal middle
			//	 add x to right
			for (int i = 0; i < middle; i++)
			{
				listLeft.Add(list[i]);
			}
			for (int i = middle; i < list.Count; i++)
			{
				listRight.Add(list[i]);
			}

			// recursively call merge_sort() to further split each sublist
			//until sublist size is 1
			listLeft = mergeSort(listLeft); //left
			listRight = mergeSort(listRight); //right

			// merge the sublists returned from prior calls to merge_sort()
			// and return the resulting merged sublist
			return merge(listLeft, listRight);
		}
	}

	private static List<int> merge(List<int> listLeft, List<int> listRight)
	{
		List<int> listResult = new List<int>();
		while ((listLeft.Count > 0) || (listRight.Count > 0))
		{
			if ((listLeft.Count > 0) && (listRight.Count > 0))
			{
				if (listLeft[0] <= listRight[0])
				{
					listResult.Add(listLeft[0]);
					listLeft.Remove(listLeft[0]);
				}
				else
				{
					listResult.Add(listRight[0]);
					listRight.Remove(listRight[0]);
				}
			}
			else if (listLeft.Count > 0)
			{
				listResult.Add(listLeft[0]);
				listLeft.Remove(listLeft[0]);
			}
			else if (listRight.Count > 0)
			{
				listResult.Add(listRight[0]);
				listRight.Remove(listRight[0]);
			}
		}
		return listResult;
	}

	private static void Main()
	{
		// Deklarations
		Random rand = new Random();
		List<int> mainList = new List<int>();
		int lenghtOfArray = rand.Next(6, 25);
		int[] arrayOfInteger = new int[lenghtOfArray];//{ -6, -2, -1, -6, 5, 8, -3, -1, 1, 0, -4, 4, 5, 9, -9, -3, -11, -8, -4, 3, -5, -2, 4, 7 }; //

		//generate random array
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = rand.Next(-11, 11);
			mainList.Add(arrayOfInteger[i]);
			Console.Write("{0,2} ", arrayOfInteger[i]);
		}
		Console.WriteLine();

		// Solution

		mainList = mergeSort(mainList);
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			arrayOfInteger[i] = mainList[i];
		}

		// Output
		for (int i = 0; i < arrayOfInteger.Length; i++)
		{
			Console.Write("{0,2} ", arrayOfInteger[i]);
		}
		Console.WriteLine();
	}
}