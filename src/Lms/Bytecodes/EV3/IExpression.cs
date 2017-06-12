using System;
using System.Collections.Generic;
using System.Text;

namespace Dandy.Lms.Bytecodes.EV3
{
    /// <summary>
    /// Common interface for all bytecode expressions.
    /// </summary>
    /// <remarks>
    /// Expressions are things like variables, unary operators, binary operators, and so on.
    /// </remarks>
    public interface IExpression : IByteCode
    {
    }

    /// <summary>
    /// Interface that declares the type returned by an <see cref="IExpression"/> when it is evaluated.
    /// </summary>
    /// <typeparam name="T">The type of the expression.</typeparam>
    public interface IExpression<T> : IExpression where T : VMDataType
    {
        /// <summary>
        /// Gets an index accessor expression.
        /// </summary>
        /// <param name="index">The index of an element.</param>
        /// <returns>A new expression.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown if this expression is not a string or an array.
        /// </exception>
        IExpression<Data8> this[int index] { get; }
    }
}
