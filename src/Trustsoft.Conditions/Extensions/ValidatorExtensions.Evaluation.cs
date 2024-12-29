﻿//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Evaluation.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

using Trustsoft.Conditions.Internals;

[SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
public static partial class ValidatorExtensions
{
    #region " Evaluate "

    /// <summary>
    ///   Checks whether the specified <paramref name="expression" />
    ///   evaluates to <see langword="true" /> on the given value.
    /// </summary>
    /// <remarks>
    ///   This method will display a string representation of the specified <paramref name="expression" />.
    ///   Although it can therefore give a lot of useful information in the exception message.
    ///   The <paramref name="expression" /> has to be compiled on each call.
    /// </remarks>
    /// <typeparam name="T"> The type of the given value of the specified <paramref name="validator" />. </typeparam>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="expression">
    ///   The <see cref="Expression{T}" /> that will be compiled to an <see cref="Func{T, TResult}" /> and executed.
    ///   When the expression is a null reference it is considered to evaluate to <see langword="false" />.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    public static IArgumentValidator<T> Evaluate<T>(this IArgumentValidator<T> validator,
                                                    Expression<Func<T, bool>> expression,
                                                    string? conditionDescription = null)
    {
        bool valueIsValid = false;

        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        // Don't throw an ArgumentException when the expression is null, just consider it to be invalid.
        if (expression != null)
        {
            Func<T, bool> func = expression.Compile();

            valueIsValid = func(validator.Argument.Value);
        }

        if (!valueIsValid)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.LambdaXShouldHoldForValue,
                                             false,
                                             expression!);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}