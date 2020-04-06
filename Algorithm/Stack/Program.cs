using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// スタックの利用について
/// 参考URL
/// http://algorithms.blog55.fc2.com/blog-entry-132.html
/// 1 3 4 2 8 7 1
/// </summary>

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var data = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                data[i] = int.Parse(line[i]);
            }
            Console.WriteLine(Gorioshi(data));
            Console.ReadKey();
        }

        //O(n^2)のアルゴリズム(考えられる全長方形を確認して最大値を残しておく)
        static int Gorioshi(int[] data)
        {
            int maxV = 0;//長方形の面積の最大値
            for (int i = 0; i < data.Length; i++)
            {
                for(int j = i; j < data.Length; j++)
                {
                    int minH = int.MaxValue;
                    for (int k = i; k <= j; k++)
                    {
                        minH = Math.Min(minH, data[k]);//data[i]からdata[j]までの最小値
                    }
                    Console.WriteLine(minH * (j - i + 1));
                    maxV = Math.Max(maxV, minH * (j - i + 1));
                }
            }
            return maxV;
        }

        //O(n)のアルゴリズム(スタックを利用)
        static int Kashikoi(int[] data)
        {
            int maxV = 0;
            int rect = 0;
            var stack = new Stack<int>();
            for(int i = 0; i < data.Length; i++)
            {
                if(stack.Count == 0)
                {

                }
            }
            return maxV;
        }
    }
}
