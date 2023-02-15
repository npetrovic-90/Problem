using System;
using System.Collections.Generic;

namespace Problem
{
	class CustomList
	{
		//list of elements
		List<int> list1 = new List<int>(new int[] { 1, 8, 15, });
		List<int> list2 = new List<int>(new int[] { 2, 7, 12, });
		List<int> list3 = new List<int>(new int[] { 10, 13, 14, });
		//iterators for each list
		int i = 0;
		int j = 0;
		int k = 0;

		public int getNext()
		{
			if (list1.Count + list2.Count + list3.Count == i + j + k)
				return 0;

			int result = 0;

			if (list1.Count != i && list2.Count != j && list3.Count != k)
			{
				if (list1[i] < list2[j] && list1[i] < list3[k])
				{
					result = list1[i];
					i++;
				}
				else if (list2[j] < list1[i] && list2[j] < list3[k])
				{
					result = list2[j];
					j++;
				}
				else
				{
					result = list3[k];
					k++;
				}
			}

			else if (list1.Count != i && list2.Count != j && list3.Count == k)
			{
				if (list1[i] < list2[j])
				{
					result = list1[i];
					i++;
				}
				else
				{
					result = list2[j];
					j++;
				}

			}
			else if (list1.Count != i && list2.Count == j && list3.Count != k)
			{
				if (list1[i] < list3[k])
				{
					result = list1[i];
					i++;
				}
				else
				{
					result = list3[k];
					k++;
				}

			}
			else if (list1.Count == i && list2.Count != j && list3.Count != k)
			{
				if (list2[j] < list3[k])
				{
					result = list2[j];
					j++;
				}
				else
				{
					result = list3[k];
					k++;
				}
			}

			else if (list1.Count != i)
			{
				result = list1[i];
				i++;
			}
			else if (list2.Count != j)
			{
				result = list2[j];
				j++;
			}
			else if (list3.Count != k)
			{
				result = list3[k];
				k++;
			}

			return result;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{

			CustomList problem = new CustomList();

			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());
			Console.WriteLine(problem.getNext());

		}
	}
}
