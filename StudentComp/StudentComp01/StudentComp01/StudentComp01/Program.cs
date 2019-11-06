using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] str = Console.ReadLine().Split(' ');//2つ以上のスペース区切り入力の取得
            M = int.Parse(str[0]);  //数値で受け取りたい場合は変換する
            N = int.Parse(str[1]);
            int num1, num2, num3;
            int counter = 0;

            for (int i = 1; i <= M; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    num1 = j / 10;
                    num2 = j % 10;
                    num3 = num1 * num2;

                    if (num3 == i && num1 >= 2 && num2 >= 2)
                    {
                        counter += 1;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
