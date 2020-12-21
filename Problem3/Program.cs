using System;

namespace Problem3 {
	class Program {
		static void Main(string[] args) {

			long num = 600851475143;
			long max = 0;
			int maxFactor = Convert.ToInt32(Math.Floor(Math.Sqrt(num)));

			for (long i = 2; i < maxFactor; i++) {

				if(num % i == 0) {

					bool isPrime = true;

					for(long j = 2; j < i; j++) {

						if(i % j == 0) {

							isPrime = false;
							break;
						}
					}
					if(isPrime) {
						max = i;
					}
				}
			}
			Console.WriteLine(max);
		}
	}
}
