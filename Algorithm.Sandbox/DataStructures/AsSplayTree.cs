﻿using System;

namespace Algorithm.Sandbox.DataStructures
{
    public class AsSplayTreeNode<I, V> where I : IComparable
    {
        public I Identifier { get; set; }
        public V Value { get; set; }

        public AsSplayTree<I, V> Left { get; set; }
        public AsSplayTree<I, V> Right { get; set; }

        public bool IsLeaf => Left == null && Right == null;

        public AsSplayTreeNode(I identifier, V value)
        {
            this.Identifier = identifier;
            this.Value = value;
        }

    }

    public class AsSplayTree<I, V> where I : IComparable
    {
        public AsSplayTreeNode<I, V> Root { get; set; }

    }
}
