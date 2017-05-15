using System;
namespace fibonacci{
    class MainClass{
        public static void Main(){
            for (int i = 0; i < 100; i++){
                Console.WriteLine("n : " + i.ToString() + " = " + fibonacci(i).ToString());
            }
        }
        private static int fibonacci(int value){
			if (value == 0) return 0;
			if (value == 1) return 1;
			return fibonacci(value - 2) + fibonacci(value - 1);
        }

    }
}