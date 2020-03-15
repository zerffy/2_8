using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace calculator2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            try
            {
                string s = Console.ReadLine();//获取第一个数字
                cal.X = Convert.ToInt32(s); //转换
            }
            catch
            {
                Console.WriteLine("输入第一个数字错误引发异常！！！");
            }
            string ysf= Console.ReadLine();//获取运算符
            try
            {
                string t = Console.ReadLine();//获取第二个数字
                cal.Y = Convert.ToInt32(t); //转换
            }
            catch
            {
                Console.WriteLine("输入第二个数字错误引发异常！！！");
                Thread.Sleep(5000);
            }
            cal.Equals();
            switch (ysf)
            {
                case "+":
                    cal.Add();
                    break;
                case "-":
                    cal.Subtract();
                    break;
                case "*":
                    cal.Multiplication();
                    break;
                case "/":
                    cal.Division();
                    break;
                default:
                    Console.WriteLine("输入运算符错误引发异常!!!");
                    break;
            }
        }
    }
}
