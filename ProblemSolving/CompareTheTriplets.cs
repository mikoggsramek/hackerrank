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
	public class CompareTheTriplets {
		// Complete the compareTriplets function below.
		static List<int> compareTriplets(List<int> a, List<int> b) {
			List<int> answer = new List<int>();
			int aPoints = 0;
			int bPoints = 0;

			for(int i = 0; i < a.Count; i++) {
				if(a[i] > b[i]) {
					aPoints++;
				}else if(a[i] < b[i]) {
					bPoints++;
				}
			}
			answer.Add(aPoints);
			answer.Add(bPoints);
			return answer;
		}

		public static void Run() {
			List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

			List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

			List<int> result = compareTriplets(a, b);

			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
