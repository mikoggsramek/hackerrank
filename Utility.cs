using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank {
	class Utility {
		public static void PrintArray(int[] arr) {
			for(int i = 0; i < arr.Length; i++) {
				Console.Write(arr[i]);
				if(i < arr.Length - 1) {
					Console.Write(", ");
				}
			}
			Console.WriteLine("");
		}
		public static void PrintArray(string[] arr) {
			for (int i = 0; i < arr.Length; i++) {
				Console.Write(arr[i]);
				if (i < arr.Length - 1) {
					Console.Write(", ");
				}
			}
			Console.WriteLine("");
		}
	}
}
