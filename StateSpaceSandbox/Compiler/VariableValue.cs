﻿using System;
using StateSpaceSandbox.Model;

namespace StateSpaceSandbox.Compiler
{
    /// <summary>
    /// Describes a constant value
    /// </summary>
    public sealed class VariableValue : IValueProvider
    {
        /// <summary>
        /// Gets the value
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstantValue" /> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public VariableValue(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Determines if this constant is <code>1.0D</code>
        /// </summary>
        public bool IsOne
        {
            get { return Math.Abs(Value - 1.0D) <= Double.Epsilon; }
        }

        /// <summary>
        /// Determines if this constant is <code>0.0D</code>
        /// </summary>
        public bool IsZero
        {
            get { return Math.Abs(Value) <= Double.Epsilon; }
        }
    }
}
