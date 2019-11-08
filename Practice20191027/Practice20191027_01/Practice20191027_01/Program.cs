using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20191027_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            string[] str = Console.ReadLine().Split(' ');//2つ以上のスペース区切り入力の取得
            A = int.Parse(str[0]);  //数値で受け取りたい場合は変換する
            B = int.Parse(str[1]);
            int answer;
            if (A < 10 && B < 10)
            {
                answer = A * B;
            }
            else {
                answer = -1;
            }

            Console.WriteLine(answer);
        }
    }
}
