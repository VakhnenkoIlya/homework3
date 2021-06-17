using System;
using BenchmarkDotNet.Attributes;


namespace homework3
{
    public class  Benchmark
    {
        public int X;
        public int Y;
        public  float PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public  float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
        }
        public double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }
        public float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        [Benchmark]
        public void TestPointClassDistanceFloat()
        {
            var pointOne = new PointClass() { X = 5, Y = 5 };
            var pointTwo = new PointClass() { X = 11, Y = 11 };
            PointDistance(pointOne, pointTwo);
        }
        [Benchmark]
        public void TestPointStructDistanceFloat()
        {
            var pointOne = new PointStruct() { X = 5, Y = 5 };
            var pointTwo = new PointStruct() { X = 11, Y = 11 };
            PointDistance(pointOne, pointTwo);
        }
        [Benchmark]
        public void TestPointStructDistanceDouble()
        {
            var pointOne = new PointStruct() { X = 5, Y = 5 };
            var pointTwo = new PointStruct() { X = 11, Y = 11 };
            PointDistanceDouble(pointOne, pointTwo);
        }
        [Benchmark]
        public void TestPointStructDistanceShortFloat()
        {
            var pointOne = new PointStruct() { X = 5, Y = 5 };
            var pointTwo = new PointStruct() { X = 11, Y = 11 };
            PointDistanceShort(pointOne, pointTwo);
        }
    }
}
