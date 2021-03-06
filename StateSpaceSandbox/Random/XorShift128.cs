﻿using System;

namespace StateSpaceSandbox.Random
{
    /// <summary>
    /// Xorshift-128 Random Number Generator
    /// </summary>
    public sealed class XorShift128
    {
        private uint _x;
        private uint _y;
        private uint _z; 
        private uint _w;

         /// <summary>
        /// Initializes a new instance of the <see cref="XorShift128" /> class.
        /// </summary>
        public XorShift128()
            : this(123456789 ^ Environment.TickCount, 362436069 ^ Environment.TickCount, 521288629 ^ Environment.TickCount, 88675123 ^ Environment.TickCount)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XorShift128" /> class.
        /// </summary>
        /// <param name="seedX">The seed X.</param>
        /// <param name="seedY">The seed Y.</param>
        /// <param name="seedZ">The seed Z.</param>
        /// <param name="seedW">The seed W.</param>
        public XorShift128(int seedX, int seedY, int seedZ, int seedW)
        {
            _x = (uint)seedX;
            _y = (uint)seedY;
            _z = (uint)seedZ;
            _w = (uint)seedW;
        }

        /// <summary>
        /// Gets the next integer value
        /// </summary>
        /// <returns>The random number</returns>
        public int Next()
        {
            // http://www.jstatsoft.org/v08/i14/paper

            uint t = _x ^ (_x << 11);
            _x = _y; _y = _z; _z = _w;
            _w ^= (_w >> 19) ^ t ^ (t >> 8);

            return (int)_w;
        }

        /// <summary>
        /// Gets the next double value
        /// </summary>
        /// <returns>The random number</returns>
        public double NextDouble()
        {
            uint rnd = (uint)Next();
            double scaling = 1.0D / UInt32.MaxValue;
            double value = 2.0D * (rnd * scaling - 0.5D);
            return value;
        }
    }
}
