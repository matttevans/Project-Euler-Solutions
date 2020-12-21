using System;

namespace Problem4 {
	class Problem4 {
		static void Main(string[] args) {

			Problem4 p4 = new Problem4();

			int max = 0;
			int num;

			for(int i = 999; i > 99; i--) {

				for (int j = 999; j > 99; j--) {

					num = i * j;

					if (num == p4.ReverseInt(num)) {

						if(num > max) {

							max = num;
						}
					}
				}
			}
			Console.WriteLine(max);
		}

		public int ReverseInt(int num) {

			int result=0;
			while (num > 0) {

				result = result * 10 + num % 10;
				num /= 10;
			}
			return result;
		}
	}
}
