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
	class AVeryBigSum {
		static long aVeryBigSum(long[] ar) {
			long answer = 0;
			for(int i = 0; i < ar.Length; i++) {
				answer += ar[i];
			}
			return answer;
		}

		public static void Run() {

			int arCount = Convert.ToInt32(Console.ReadLine());

			long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
			long result = aVeryBigSum(ar);

			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
