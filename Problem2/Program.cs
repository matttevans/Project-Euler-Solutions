using System;

namespace Problem2 {
	class Program {
		static void Main(string[] args) {

			long sum = 0;
			long result = 0;
			long fib1 = 1;
			long fib2 = 1;

			while (sum < 4000000) {

				if ((result % 2) == 0) {

					sum += result;
				}

				result = fib1 + fib2;
				fib2 = fib1;
				fib1 = result;
			}
			Console.WriteLine(sum);
		}
	}
}
