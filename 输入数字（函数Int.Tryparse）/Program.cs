using System;

namespace 输入数字_函数Int.Tryparse_
{
    class Program
    {
        static public int InputNum()
        {
            while(true)
            {
                Console.WriteLine("请输入一个数字：");
                string input = Console.ReadLine();
                int num;

                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("请重新输入数字：");
                    continue;
                }
                return num;
            }
        }
        // 失败 
        // return InputNum(); 递归，自己调用自己，输入错误6w次，调用栈无限递归就会崩溃
        // 这里要用循环代替

        static void Main(string[] args)
        {
            int a = InputNum();
            Console.WriteLine(a);
        }
    }
}
