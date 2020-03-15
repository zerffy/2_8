using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculator2_5
{
    class Calculator
    {
        float x;
        float y;

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public void Add()
        {
            try
            {
                Console.WriteLine(x + "+" + y + "=" + (x + y));
            }
            catch
            {
                Console.WriteLine("无法运算！！！");
            }
            
        }/// <summary>
        /// 
        /// </summary>
        /// <param name="str1">第一个字符串</param>
        /// <param name="str2">第二个字符串</param>
        public void Add(string str1,string str2)//重载 对输入的两个字符串进行连接运算
        {
            Console.WriteLine(str1+"+"+str2+"="+str1+str2);
        }
        public void Subtract()
        {
            try
            {
                Console.WriteLine(x + "-" + y + "=" + (x - y));
            }
            catch
            {
                Console.WriteLine("无法运算！！！");
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str1">第一个字符串</param>
        /// <param name="str2">第二个字符串</param>
        public void Subtract(string str1, string str2)//重载 从用户输入的第一个字符串中去除第二个字符串
        {
            Console.WriteLine(str1 + "-" + str2 + "="+str1.Replace(str2, ""));
        }
        public void Multiplication()
        {
            try
            {
                Console.WriteLine(x + "*" + y + "=" + (x * y));
            }
            catch
            {
                Console.WriteLine("无法运算！！！");
                
            }
        }
        public void Division()
        {
            try
            {
                Console.WriteLine(x + "/" + y + "=" + (x / y));
            }
            catch
            {
                Console.WriteLine("无法运算！！！");
                
            }
        }
        public void Equals()
        {
            if (x == y)
                Console.WriteLine("这两个整数相等");
            else Console.WriteLine("这两个整数不相等");
        }
    }
}
