﻿namespace CodeWars.Katas.Kyu8
{
    //  Complete the square sum function so that it squares each number passed into it and then sums the results together.
    //
    //  For example, for [1, 2, 2] it should return 9 because 1^2+2^2+2^2=9
    public static class SquareNSum
    {
        public static int SquareSum(int[] numbers) =>
            (int)numbers.Sum(i => Math.Pow(i, 2));
    }
}
