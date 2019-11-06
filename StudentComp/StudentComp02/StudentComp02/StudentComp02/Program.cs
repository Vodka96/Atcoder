using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentComp02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,K;
            string[] str = Console.ReadLine().Split(' ');//2つ以上のスペース区切り入力の取得
            N = int.Parse(str[0]);  //数値で受け取りたい場合は変換する
            K = int.Parse(str[1]);

            string[] str2 = Console.ReadLine().Split(' ');        
            int counter = 0;

            var box = new List<int>();

            //making big list
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    box.Add(int.Parse(str2[j]));
                }
            }

            for (int i = 0; i < N*K-1; i++)
            {
                for (int j = i+1; j < N*K ; j++)
                {
                    if (box[i] > box[j]) {
                        counter++;
                    }
                }
            }

            int answer = counter % (10 ^ 9 + 7);
            Console.WriteLine(answer);
        }
    }
}
