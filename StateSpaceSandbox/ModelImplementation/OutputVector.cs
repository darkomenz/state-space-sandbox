﻿using StateSpaceSandbox.Model;

namespace StateSpaceSandbox.ModelImplementation
{
    /// <summary>
    /// Output vector implementation
    /// </summary>
    internal sealed class OutputVector : AbstractVector, IOutputVector
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlVector" /> class.
        /// </summary>
        /// <param name="length">The length.</param>
        public OutputVector(int length)
            : base(length)
        {
        }

        /// <summary>
        /// Adds a control vector to this instance and returns the summed vector
        /// </summary>
        /// <param name="other">The vector to add</param>
        public IOutputVector Add(IOutputVector other)
        {
            IVector result = new OutputVector(Length);
            Add(other, ref result);
            return (IOutputVector)result;
        }

        /// <summary>
        /// Adds a control vector to this instance and returns the summed vector
        /// </summary>
        /// <param name="other">The vector to add</param>
        public void AddInPlace(IOutputVector other)
        {
            base.AddInPlace(other);
        }

        /// <summary>
        /// Adds a control vector to this instance and returns the summed vector
        /// </summary>
        /// <param name="other">The vector to add</param>
        /// <param name="output">The output.</param>
        public void Add(IOutputVector other, ref IOutputVector output)
        {
            IVector result = output;
            Add(other, ref result);
        }
    }
}