using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Fibonocciseries
    {
        public int firstNum = 0, secondNum = 1, result = 0;
        public void Findfibonocciseries()
        {
            Console.WriteLine("please enter a number to create series:");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("user number is"+num);
            result = firstNum + secondNum;
            Console.WriteLine("Series are:" + firstNum + " " + secondNum);
            for(int i=2;i<num;i++)
            {
                firstNum = secondNum;
                secondNum = result;
                Console.WriteLine(" " + result);
                result= firstNum + secondNum;
            }
        }
    }
}
