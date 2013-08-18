using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class DivisionAlgorithm
    {
		public static Range<T> FindMaxSumSublist<T>(IList<T> source, Range<T> range)
            where T : IAdd<T>
        {
            if (range.Low == range.High)
            {
                Range<T> result = new Range<T>();
                result.Low = range.Low;
                result.High = range.High;
                result.Sum = source[range.Low];
                return result;
            }
            else
            {
                Range<T> leftRange = new Range<T>();
                int middle = (range.Low + range.High) / 2;
                leftRange.Low = range.Low;
                leftRange.High = middle;
                Range<T> leftResult = FindMaxSumSublist(source, leftRange);

                Range<T> rightRange = new Range<T>();
                rightRange.Low = middle + 1;
                rightRange.High = range.High;
                Range<T> rightResult = FindMaxSumSublist(source, rightRange);

                Range<T> crossRange = new Range<T>();
                crossRange.Low = range.Low;
                crossRange.High = range.High;
                crossRange.Middle = middle;
                Range<T> crossResult = FindCrossMaxSumSublist(source, crossRange);

                if (leftResult.Sum.CompareTo(rightResult.Sum) >= 0 && leftResult.Sum.CompareTo(crossResult.Sum) >= 0)
                    return leftResult;
                else if (rightResult.Sum.CompareTo(leftResult.Sum) >= 0 && rightResult.Sum.CompareTo(crossResult.Sum) >= 0)
                    return rightResult;
                else
                    return crossResult;
            }
        }

        private static Range<T> FindCrossMaxSumSublist<T>(IList<T> source, Range<T> range)
            where T : IAdd<T>
        {
            int maxLeft = range.Middle;
            T leftSum = source[maxLeft];
            T maxLeftSum = leftSum;
            for (int i = maxLeft-1; i >= range.Low; i--)
            {
                leftSum = leftSum.Add(source[i]);
                if (leftSum.CompareTo(maxLeftSum) == 1)
                {
                    maxLeftSum = leftSum;
                    maxLeft = i;
                }
            }

            int maxRight=range.Middle+1;
            T rightSum = source[maxRight];
            T maxRightSum = rightSum;
            
            for (int i = maxRight+1; i <= range.High; i++)
            {
                rightSum = rightSum.Add(source[i]);
                if (rightSum.CompareTo(maxRightSum) == 1)
                {
                    maxRightSum = rightSum;
                    maxRight = i;
                }
            }
            Range<T> crossResult = new Range<T>();
            crossResult.Low = maxLeft;
            crossResult.High =maxRight;
            crossResult.Sum = maxLeftSum.Add(maxRightSum);
            return crossResult;
        }
    }
}
