﻿using Algorithm.Sandbox.DataStructures;
using Algorithm.Sandbox.DataStructures.Heap.Min;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Sandbox.Tests.DataStructures
{
    [TestClass]
    public class AsD_aryTree_Tests
    {
        /// <summary>
        /// A tree test
        /// </summary>
        [TestMethod]
        public void AsD_aryHeap_Test()
        {
            var initial = new List<int>();

            for (int i = 0; i <= 50; i++)
            {
                initial.Add(i);
            }

            //insert test
            var tree = new D_aryMinHeap<int>(4, initial);

            for (int i = 51; i <= 99; i++)
            {
                tree.Insert(i);
            }

            for (int i = 0; i <= 99; i++)
            {
                var min = tree.ExtractMin();
                Assert.AreEqual(min, i);
            }

            var rnd = new Random();
            var testSeries = Enumerable.Range(1, 49).OrderBy(x => rnd.Next()).ToList();

            foreach (var item in testSeries)
            {
                tree.Insert(item);
            }

            for (int i = 1; i <= 49; i++)
            {
                var min = tree.ExtractMin();
                Assert.AreEqual(min, i);
            }

        }
    }
}
