using System;

namespace ora1
{
    class Object {
        static int max, min, num;

        public Object(){
            num = 10;
            max++;
            min++;
            Console.WriteLine(max);
        }

        ~Object() {
            max--;
        }

        public int getMax() {
            return max;
        }

        public int getMin()
        {
            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            for (int i = 0; i < 500000; i++) {
                Object myObj = new Object();
                if (myObj.getMin() > myObj.getMax()) {
                    break;
                }
            }
        }
    }
}
