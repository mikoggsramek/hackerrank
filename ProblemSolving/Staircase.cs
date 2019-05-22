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
	class Staircase {
		static void solution(int n) {
			int row = 1;
			for(int i = 0; i < n; i++) {
				for(int o = 0; o < n - row; o++) {
					Console.Write(" ");
				}
				for (int o = 0; o < row; o++) {
					Console.Write("#");
				}
				row++;
				Console.WriteLine();
			}
		}
		public static void Run() {
			int n = Convert.ToInt32(Console.ReadLine());
			solution(n);
			Console.ReadLine();
		}
	}
}
