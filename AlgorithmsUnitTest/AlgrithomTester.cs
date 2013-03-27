using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Algorithms;
using System.Diagnostics;
namespace AlgrithomUnitTest
{
    [TestFixture]
    public class AlgrithomTester
    {

        public int[] m_ints;
		//测试归并排序的元素数量
        private int LOOPCOUNT = 20000000;

        public AlgrithomTester()
        {
            m_ints = new int[LOOPCOUNT]; 
        }
        [Test]
        public void TestInsertionTest()
        {
            int[] ints = new int[]{3, 9, 1, 4, 0};
            SortHelper.InsertionSort(ints, true);
            Assert.AreEqual(0, ints[0]);
            Assert.AreEqual(1, ints[1]);
            Assert.AreEqual(3, ints[2]);
            Assert.AreEqual(4, ints[3]);
            Assert.AreEqual(9, ints[4]);
            SortHelper.InsertionSort(ints, false);
			Assert.AreEqual(0, ints[4]);
            Assert.AreEqual(1, ints[3]);
            Assert.AreEqual(3, ints[2]);
            Assert.AreEqual(4, ints[1]);
            Assert.AreEqual(9, ints[0]);
            ints = new int[] { 1 };
            SortHelper.InsertionSort(ints, true);
            Assert.AreEqual(1, ints[0]);
            ints = new int[] { 2, 1 };
            SortHelper.InsertionSort(ints, true);
            Assert.AreEqual(1, ints[0]);
            Assert.AreEqual(2, ints[1]);
            ints = new int[] { 10, 10 };
            SortHelper.InsertionSort(ints, false);
            Assert.AreEqual(10, ints[0]);
            Assert.AreEqual(10, ints[1]);
            for (int i = 10, j = 0; i > 0; i--)
            {
                m_ints[j++] = i;
            }
            SortHelper.InsertionSort(m_ints, true);
        }

        [Test]
        public void TestMergeSort()
        { 
			int [] ints = new int[]{10,9,8,7,45,641,134,5515};
            SortHelper.MergeSort(ints, 0, ints.Length - 1,true);
            Assert.AreEqual(7, ints[0]);
            Assert.AreEqual(8, ints[1]);
            Assert.AreEqual(9, ints[2]);
            Assert.AreEqual(10, ints[3]);
            SortHelper.MergeSort(ints, 0, ints.Length - 1, false);
            Assert.AreEqual(5515, ints[0]);
            ints = new int[] { 2, 1 };
            SortHelper.MergeSort(ints, 0, 1, true);
			Assert.AreEqual(1,ints[0]);
			Assert.AreEqual(2,ints[1]);
            ints = new int[] { 1 };
            Assert.AreEqual(1, ints[0]);
            for (int i = LOOPCOUNT, j = 0; i > 0; i--)
            {
                m_ints[j++] = i;
            }
            SortHelper.MergeSort(m_ints, 0, LOOPCOUNT - 1, true);
        }
    }
} 