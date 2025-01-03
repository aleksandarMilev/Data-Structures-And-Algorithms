﻿namespace DataStructuresAndAlgorithms.DataStructures.Linear.Queue
{
    public interface IMyQueue<T> : IEnumerable<T>
    {
        int Count { get; }
        void Enqueue(T element);
        T Peek();
        T Dequeue();
        bool Contains(T element);
    }
}
