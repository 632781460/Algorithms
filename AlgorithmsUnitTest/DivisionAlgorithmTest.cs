using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Algorithms;
namespace AlgrithomUnitTest
{
	public  class DivisionAlgorithmTest
    {
		[Test]
        public void TestValueTypeWrapper()
        {
            ValueTypeWrapper<int> value = ValueTypeWrapper<Int32>.Create(15);
            Assert.AreEqual(15, value.Value);
        }

        [Test]
        public void TestMAXSumSubListWrapper()
        {
            ValueTypeWrapper<int> value = ValueTypeWrapper<Int32>.Create(15);
            IList<ValueTypeWrapper<int>> intLst = new List<ValueTypeWrapper<Int32>>{
				ValueTypeWrapper<int>.Create(-11),
				ValueTypeWrapper<int>.Create(6),
				ValueTypeWrapper<int>.Create(3),
				ValueTypeWrapper<int>.Create(10),
				ValueTypeWrapper<int>.Create(-1),
				ValueTypeWrapper<int>.Create(-2),
				ValueTypeWrapper<int>.Create(-3),
				ValueTypeWrapper<int>.Create(-4),
				ValueTypeWrapper<int>.Create(-10),
				ValueTypeWrapper<int>.Create(11),
				ValueTypeWrapper<int>.Create(12),
				ValueTypeWrapper<int>.Create(19),
				ValueTypeWrapper<int>.Create(20),
				ValueTypeWrapper<int>.Create(-9),
				ValueTypeWrapper<int>.Create(-10),
				ValueTypeWrapper<int>.Create(12)
            };
            IList<ValueTypeWrapper<int>> intLst1 = new List<ValueTypeWrapper<Int32>>
            {
				ValueTypeWrapper<int>.Create(-11),
				ValueTypeWrapper<int>.Create(11)
            };
			Range<ValueTypeWrapper<int>> initValue = new Range<ValueTypeWrapper<int>>();
			initValue.Low=0;
            initValue.High = intLst.Count - 1;
            Range<ValueTypeWrapper<int>> result = DivisionAlgorithm.FindMaxSumSublist(intLst, initValue);
            Assert.AreEqual(62, result.Sum.Value);
        }
    }
}
