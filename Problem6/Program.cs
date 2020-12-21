using System;

namespace Problem6 {
	class Program {
		static void Main(string[] args) {


			int sumOfSquares = 0;
			int squareOfSum = 0;

			for(int i = 1; i < 101; i++) {

				sumOfSquares += Convert.ToInt32(Math.Pow(i, 2));
				squareOfSum += i;
			}
			Console.WriteLine(Math.Pow(squareOfSum, 2) - sumOfSquares);
		}
	}
}
