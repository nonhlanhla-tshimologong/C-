﻿using System;

namespace TempRecords
{
    public class TempRecord
    {
        // Array of temperature values
        float[] temps = new float[10]
        {
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };

        // To enable client code to validate input
        // when accessing your indexer.
        public int Length => temps.Length;

        // Indexer declaration.
        // If index is out of range, the temps array will throw the exception.
        public float this[int index]
        {
            get => temps[index];
            set => temps[index] = value;
        }
    }
    class Program
    {
        static void Main()
        {
            var tempRecord = new TempRecord();

            // Use the indexer's set accessor
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            // Use the indexer's get accessor
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        /* Output:
            Element #0 = 56.2
            Element #1 = 56.7
            Element #2 = 56.5
            Element #3 = 58.3
            Element #4 = 58.8
            Element #5 = 60.1
            Element #6 = 65.9
            Element #7 = 62.1
            Element #8 = 59.2
            Element #9 = 57.5
        */
    }
}
