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
	class DiagonalDifference {
		// Complete the diagonalDifference function below.
		static int diagonalDifference(int[][] arr) {
			int right = 0;
			int left = 0;

			for(int i = 0; i < arr.Length; i++) {
				right += arr[i][i];
				left += arr[i][(arr.Length-1) - i];
			}

			return Math.Abs(right - left);
		}

		public static void Run() {

			int n = Convert.ToInt32(Console.ReadLine());

			int[][] arr = new int[n][];

			for (int i = 0; i < n; i++) {
				arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			}

			int result = diagonalDifference(arr);

			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
