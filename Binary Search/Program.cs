using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Binary Search(二分探索)について
/// 同じ値が複数ある場合はどちらかのインデックスを表示
/// </summary>

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            //ランダムに10コの整数をnums[]に格納してソートする;
            var nums = new int[10];
            var random = new Random();
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(1, 101);
            }
            Array.Sort(nums);
            //配列numsの要素を表示
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("探したい整数の値(1～100)を入力して下さい");
            var x = int.Parse(Console.ReadLine());

            //ここから二分探索
            int left = 0;
            int right = nums.Length - 1;
            int middle = (left + right) / 2;
            while(left <= right)
            {
                if (nums[middle] < x)
                {
                    left = middle + 1;
                }
                else if(nums[middle] == x)
                {
                    Console.WriteLine("その値のインデックスは{0}です", middle);
                    break;
                }
                else
                {
                    right = middle - 1;
                }
                middle = (left + right) / 2;
            }
            if (left > right)
            {
                Console.WriteLine("お探しの値はこの配列にはありません");
            }
            Console.ReadKey();
        }
    }
}
