/**
 *  Copyright (C) 2011 by Sharon Lourduraj
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *
 *  The above copyright notice and this permission notice shall be included in
 *  all copies or substantial portions of the Software.
 *
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *  THE SOFTWARE.
 */
using System.Diagnostics;

namespace sharonjl.utils
{ 
    internal class Program
    {
        private static void Main(string[] args)
        {
            const double testLat = 40.7571397;
            const double testLong = -73.9891705;
            const int precision = 13;

            // Calculate hash with full precision
            string hash = Geohash.Encode(testLat, testLong, precision);

            // Print out the hash for a range of precision
            for (int i = 1; i <= precision; i++)
            {
                Debug.WriteLine("{0}, {1} {2}: {3}", testLat, testLong, i, Geohash.Encode(testLat, testLong, i));
            }

            // Print neighbours
            Debug.WriteLine("{0} \t: {1}", "T", Geohash.CalculateAdjacent(hash, Geohash.Direction.Top));
            Debug.WriteLine("{0} \t: {1}", "L", Geohash.CalculateAdjacent(hash, Geohash.Direction.Left));
            Debug.WriteLine("{0} \t: {1}", "R", Geohash.CalculateAdjacent(hash, Geohash.Direction.Right));
            Debug.WriteLine("{0} \t: {1}", "B", Geohash.CalculateAdjacent(hash, Geohash.Direction.Bottom));
        }
    }
}