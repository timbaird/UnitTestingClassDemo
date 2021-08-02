using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class MyMath
    {
        public int Add(List<int> nums){
            // add up all the numbers in the list and return the sum
            int answer = 0;

            foreach(int i in nums){
                answer += i;
            }

            return answer;
        }

        public double Multiply(double num1, double num2){
            // multiple num1 and num2 and return the product
            return num1 * num2;
        }

        public int Subtract(int firstNum, int subtractedNum){
            // subtract the subtractedNum from the firstNum and return the result
            return firstNum - subtractedNum;
        }

        public double Divide(double numerator, double denominator){
            // divide the numertator by the denominator and return the result
            try{
                if (denominator == 0){
                    throw new ZeroDivException("You cant divide by 0 ...noob");
                }
                return numerator / denominator;
            }
            catch{
                throw;
            }
        }
    }
}
