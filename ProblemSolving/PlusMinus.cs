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
	class PlusMinus {
		static void plusMinus(int[] arr) {
			int pos = 0;
			int neg = 0;
			int zero = 0;
			for(int i = 0; i < arr.Length; i++) {
				if(arr[i] > 0) {
					pos++;
				}else if(arr[i] < 0) {
					neg++;
				}
				else {
					zero++;
				}
			}
			int total = pos + neg + zero;
			Console.WriteLine((float)pos / total);
			Console.WriteLine((float)neg / total);
			Console.WriteLine((float)zero / total);
			
		}
		public static void Run() {
			int n = Convert.ToInt32(Console.ReadLine());

			int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
			plusMinus(arr);

			Console.ReadLine();
		}
	}
}
