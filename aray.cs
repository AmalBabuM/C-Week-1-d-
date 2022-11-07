using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace second_largest
{
    public class aray
    {
        public static void Main(string[] args)
        {
            int[] array={33,22,12,21,24};
            int n=5;
            int lar,slar;
            lar=slar=array.Min();
            for(int i=0;i<n;i++)
            {
                if(lar<array[i])
                {
                    slar=lar;
                    lar=array[i];
                }
                else if(slar<array[i]&& slar!=lar)
                {
                    slar=array[i];
                }
            }
        System.Console.WriteLine("The largest number is: {0} and the second largest number is: {1}",lar,slar);
        }
    }
}