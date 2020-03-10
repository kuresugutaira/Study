using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 累積和の利用について
/// 参考URL
/// https://paiza.hatenablog.com/entry/2015/01/21/%E3%80%90%E7%B4%AF%E7%A9%8D%E5%92%8C%E3%80%81%E3%81%97%E3%82%83%E3%81%8F%E3%81%A8%E3%82%8A%E6%B3%95%E3%80%91%E5%88%9D%E7%B4%9A%E8%80%85%E3%81%A7%E3%82%82%E8%A7%A3%E3%82%8B%E3%82%A2%E3%83%AB%E3%82%B4
/// </summary>
/// 
namespace Ruisekiwa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数のデータを空白区切りで入力する");
            Console.WriteLine("(例)1 3 10 -5 0");
            var strs = Console.ReadLine().Split(' ');
            Console.WriteLine("何個の範囲で最大値を求めるか");
            var range = int.Parse(Console.ReadLine());

            //入力された整数のデータ配列を作る
            int[] nums = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                nums[i] = int.Parse(strs[i]);
            }

            //累積和の配列を作る(要素数が元のデータ配列より1増える)
            int[] ruisekiwa = new int[nums.Length + 1];
            ruisekiwa[0] = 0;//最初は0
            for(int j=0;j < nums.Length; j++)
            {
                ruisekiwa[j + 1] = ruisekiwa[j] + nums[j];
            }
            int result = 0;
            for (int i = 0; i < ruisekiwa.Length - range; i++)
            {
                if (result < ruisekiwa[i + range] - ruisekiwa[i])
                {
                    result = ruisekiwa[i + range] - ruisekiwa[i];
                }
            }
            Console.WriteLine("最大値は{0}です", result);
            Console.ReadLine();
        }
    }
}
