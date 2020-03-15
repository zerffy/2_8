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
                Console.WriteLine("请输入第1个数字：");
                string s = Console.ReadLine();//获取第一个数字
                cal.X = Convert.ToInt32(s); //转换
            }
            catch
            {
                Console.WriteLine("请输入第1个字符串：");
                string m= Console.ReadLine();
                Console.WriteLine("请输入运算符：");
                string ysf1 = Console.ReadLine();//获取运算符
                Console.WriteLine("请输入第2个字符串：");
                string n= Console.ReadLine();
                    switch (ysf1)
                    {
                        case "+":
                            cal.Add(m, n);
                            break;
                        case "-":
                            cal.Subtract(m, n);
                            break;
                        default:
                            Console.WriteLine("输入运算符错误引发异常!!!");
                            break;
                    }
                Thread.Sleep(5000);
            }
            Console.WriteLine("请输入运算符：");
            string ysf= Console.ReadLine();//获取运算符
            try
            {
                Console.WriteLine("请输入第2个数字：");
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
