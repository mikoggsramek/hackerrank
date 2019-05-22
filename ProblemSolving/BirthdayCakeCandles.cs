using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank.ProblemSolving {
	class BirthdayCakeCandles {
		static int solution(int[] arr) {
			Array.Sort(arr);
			Array.Reverse(arr);
			int start = arr[0];
			int index = 1;
			int total = 1;
			while(index < arr.Length) {
				if(arr[index] == start) {
					total++;
				}
				else {
					break;
				}
				index++;
			}
			return total;
		}
		public static void Run() {
			int arCount = Convert.ToInt32(Console.ReadLine());

			int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
			int result = solution(ar);

			Console.WriteLine("\n" + result);
			Console.ReadLine();
		}
	}
}
