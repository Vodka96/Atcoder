using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20191027_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            string str = Console.ReadLine();//2つ以上のスペース区切り入力の取得
            int num1 = 0;
            int num2 = 0;
            string answer = "No";

            N = int.Parse(str);

            for (int i = 1; i < 10; i++)
            {
                num1 = N % i;
                num2 = N / i;
                if (num1==0 && num2<10)
                {
                    answer = "Yes";
                }

                if (answer == "Yes") {
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
