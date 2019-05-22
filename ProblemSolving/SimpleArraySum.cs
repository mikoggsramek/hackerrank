using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.ProblemSolving {
	public class SimpleArraySum {
		static int simpleArraySum(int[] ar) {
			int sum = 0;
			for (int i = 0; i < ar.Length; i++) {
				sum += ar[i];
			}
			return sum;
		}

		public static void Run() {

			int arCount = Convert.ToInt32(Console.ReadLine());

			int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
			int result = simpleArraySum(ar);

			Console.WriteLine(result);
			Console.ReadLine();

		}
	}
}
