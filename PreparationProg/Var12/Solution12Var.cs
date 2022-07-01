using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PreparationProg.Var12
{
    public class Solution12Var
    {
        //in Main
        //GetMasAsync();
        //Console.ReadLine();

        //in Program.cs
        public static Task<int[]> GetMasAsync()
        {

            var a = Task.Run(() => {
                int[] arr = new int[10];
                Random rnd = new();
                for (int x = 0; x < arr.Length; x++)
                {
                    arr[x] = rnd.Next(1, 20);
                    Thread.Sleep(5000);
                    Console.WriteLine(arr[x]);
                }
                return arr;
            });
            return a;

        }
    }
}
