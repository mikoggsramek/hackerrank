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
	class TimeConversion {
		static string solution(string s) {
			string result = "";

			string[] time = s.Split(':');
			Utility.PrintArray(time);
			string ampm = time[2].Substring(2);
			if (ampm.Equals("PM")) {
				
				int hour = (int.Parse(time[0]));
				if(hour != 12) {
					hour += 12;
				}
				result += hour + ":";
			}
			else {
				int hour = (int.Parse(time[0]));
				if (hour == 12) {
					hour -= 12;
				}
				result += "0" + hour + ":";
			}
			result += time[1] + ":";
			result += time[2].Substring(0, 2);
			return result;
		}
		public static void Run() {
			string s = Console.ReadLine();

			string result = solution(s);
			Console.WriteLine(result);
			Console.ReadLine();
		}
	}
}
