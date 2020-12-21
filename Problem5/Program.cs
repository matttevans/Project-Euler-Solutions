using System;

namespace Problem5 {

	class Program {

		static void Main(string[] args) {

			bool end = true;
			int result = 20;

			while(end) {

				int counter = 0;
				Console.WriteLine(result);

				for (int i = 21; i > 1; i--) {

					if (result % i == 0) {
						counter++;
					}
					else {
						counter = 0;
						break;
					}
					if (counter == 20) {

						Console.WriteLine(result);
						end = false;
					}
				}
				result+=20;
			}
		}
	}
}
