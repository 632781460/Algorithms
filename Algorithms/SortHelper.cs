using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class SortHelper
    {
        public static void InsertionSort<T>(IList<T> source,bool aesc)
			where T:IComparable<T>
        {
            int length = source.Count,
                compareValue = aesc ? 1:-1;
			T key = default(T);
            if (length > 1) {
                for (int i = 1; i < length; i++)
                {
                    key = source[i];
                    int ii = i - 1;
                    for (; ii >= 0 && source[ii].CompareTo(key) == compareValue; ii--)
                    {
                        source[ii + 1] = source[ii];
                    }
                    source[ii+1] = key;
                }
            }
        }

        public static void MergeSort<T>(IList<T> source, int begin, int end, bool aesc)
			where T:IComparable<T>
        {
            if (begin < end)
            {
                int mid = (begin + end) / 2;
                MergeSort<T>(source,begin, mid,aesc);
                MergeSort<T>(source, mid+1, end, aesc);
                Merge<T>(source, begin, mid, end, aesc);
            }
        }

        private static void Merge<T>(IList<T> source, int p1, int p1p2, int p2p3, bool aesc)
			where T:IComparable<T>
        {
            int a1Count = p1p2 - p1 + 1,
                a2Count = p2p3 - p1p2,
                li=0,
                ri=0,
				compareValue=aesc?-1:1,
                length=a1Count+a2Count;
            T[] a1 = new T[a1Count];
            T[] a2 = new T[a2Count];
            for (int i = 0; i < a1Count; i++)
            {
                a1[i] = source[p1+i];
            }
            for (int i = 0; i < a2Count; i++)
            {
                a2[i] = source[p1p2 + i+1]; 
            }
            for (int i = p1; i < p2p3+1; i++)
            {
                if ( ri>=a2Count || 
                    (li < a1Count  && a1[li].CompareTo(a2[ri]) == compareValue )
                   )
                {
                    source[i] = a1[li];
                    ++li;
                }
                else {
                    source[i] = a2[ri];
                    ++ri;
                }
            }
        }
    }
}
