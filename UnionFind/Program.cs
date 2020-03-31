using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UnionFindチョットワカル");
            Console.ReadKey();
        }
    }

    class UnionFind
    {
        //グループの要素数はルートの要素に負の値で保持する
        public int[] Parents { get; set; }

        public UnionFind(int size)
        {
            this.Parents = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.Parents[i] = -1;
            }
        }

        //要素xの属するグループのルート要素を返す
        public int Find(int x)
        {
            if (this.Parents[x] < 0) return x;

            this.Parents[x] = this.Find(this.Parents[x]);
            return this.Parents[x];
        }

        //要素xの属するグループの要素数を返す
        public int Size(int x)
        {
            return -this.Parents[Find(x)];
        }

        //要素xと要素yが同じグループに属しているか判別する
        public bool isSame(int x, int y)
        {
            return this.Find(x) == this.Find(y);
        }


        //要素xと要素yの属するグループを合併する
        public void Union(int x,int y)
        {
            x = this.Find(x);
            y = this.Find(y);
            if (x == y) return;
            //yの要素数≧xの要素数　になるように調節
            if(this.Size(x) > this.Size(y))
            {
                var tmp = x;
                x = y;
                y = tmp;
            }
            //yグループの要素数をxグループの要素数分だけ増やしておく
            this.Parents[y] += this.Parents[x];
            this.Parents[x] = y;
        }
    }
}
