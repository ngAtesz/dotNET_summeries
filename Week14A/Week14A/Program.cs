﻿using System;
using System.Collections;

namespace Week14A
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();
                Console.WriteLine("From Queue: {0}",obj);
            }

            Console.WriteLine("------------------------");

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From stack: {0}", obj);
            }

            Console.ReadKey();
        }
    }
}
