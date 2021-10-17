using System;
using System.Collections.Generic;
using System.Text;

namespace Course_72 {
    class Calculator {
        public static double Sum(params double[] list) {
            double sum = 0;
            foreach(double num in list) {
                sum += num;
            }
            return sum;
        }

        public static void Triple(ref int x) {
            x *= 3;
        }

        public static void Triple(int x, out int result) {
            result = x * 3;
        }
    }
}
