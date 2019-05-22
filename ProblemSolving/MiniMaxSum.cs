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
	class MiniMaxSum {
		static void solution(int[] arr) {
			double max = 0;
			double min = 0;
			Array.Sort(arr);
			for(int i = 0; i < arr.Length - 1; i++) {
				max += arr[arr.Length - 1 - i];
				min += arr[i];
			}
			Console.WriteLine(min + " " + max);
		}
		public static void Run() {
			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			solution(arr);
			Console.ReadLine();
		}
	}
}
