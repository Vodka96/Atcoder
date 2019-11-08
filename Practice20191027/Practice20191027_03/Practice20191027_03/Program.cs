using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20191027_03
{
    class Program
    {
        static void Main(string[] args)
        {
            long N;
            long M;
            string str = Console.ReadLine();
            N = long.Parse(str);
            long num1;
            long num2;
            var list = new List<long>();
            long i = 1;
            long k = -1;
            bool flag = true;
            long answer1 = 1;
            long answer2 = 1;
            long answer_real;

            while (true)
            {
                i++;
                num1 = N % i;
                num2 = N / i;
                
                    if (num1 == 0)
                    {
                        list.Add(i);
                        M = num2;
                        break;
                    }
            }

            if (i != N)
            {
                while (flag)
                {
                    long j = 1;
                    k++;

                    while (true)
                    {
                        j++;
                        num1 = M % j;
                        num2 = M / j;
                        if (M != j)
                        {
                            if (num1 == 0)
                            {
                                list.Add(j);
                                M = num2;
                                break;
                            }
                        }
                        else
                        {
                            list.Add(j);
                            flag = false;
                            break;
                        }
                    }
                    
                }
            
                 if (list.Count() % 2 == 0)
                {
                    for (int l = 0; l < list.Count() / 2; l++)
                    {
                        answer1 *= list[l];
                    }
                    for (int l = list.Count() / 2 ; l < list.Count(); l++)
                    {
                        answer2 *= list[l];
                    }
                    answer_real = answer1 + answer2 - 2;
                }

                else
                {
                    for (int l = 0; l < list.Count() / 2 + 1; l++)
                    {
                        answer1 *= list[l];
                    }
                    for (int l = list.Count() / 2+1 ; l < list.Count(); l++)
                    {
                        answer2 *= list[l];
                    }
                    answer_real = answer1 + answer2 - 2;
                }
            }
            else {
                answer_real = N - 1;
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }          
            Console.WriteLine(answer_real+"だよ。");
        }
    }
}
