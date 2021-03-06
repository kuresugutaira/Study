﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// バブルソートについて
/// 参考URL
/// https://www.codereading.com/algo_and_ds/algo/bubble_sort.html
/// </summary>

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("並び替えたい整数の値を空白区切りで入力して下さい。");
            Console.WriteLine("(例)-1 4 5 -3 2");
            string[] strs = Console.ReadLine().Split(' ');
            var nums = new List<int>();
            foreach(string str in strs)
            {
                nums.Add(int.Parse(str));
            }


            //ここからソート

            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = 0; j < nums.Count - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        //隣接する2つを入れ替える
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                    }
                }
            }
            
            //2つめのループを上から比較していくことも出来る

            /*
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = nums.Count - 1; j > i; j--)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        //隣接する2つを入れ替える
                        int tmp = nums[j - 1];
                        nums[j - 1] = nums[j];
                        nums[j] = tmp;
                    }
                }
            }
            */

            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
