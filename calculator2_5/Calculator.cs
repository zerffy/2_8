using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
