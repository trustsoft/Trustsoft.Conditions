﻿//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Guid.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions;

using System;
using System.Diagnostics.CodeAnalysis;

using Trustsoft.Conditions.Internals;

[SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
public static partial class ValidatorExtensions
{
    #region " IsEmpty "

    /// <summary>
    ///     Checks whether the given <see cref="T:System.Guid" /> is empty. An exception is thrown
    ///     otherwise.
    /// </summary>
    /// <param name="validator">
    ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown when the given value of the specified <paramref name="validator" /> is not empty.
    /// </exception>
    public static IArgumentValidator<Guid> IsEmpty(this IArgumentValidator<Guid> validator,
                                                   string? conditionDescription = null)
    {
        if (!Guid.Empty.Equals(validator.Argument.Value))
        {
            string msg = MessageBuilder.Combine(validator.Argument,
                                                conditionDescription,
                                                StringRes.GuidShouldBeEmpty,
                                                false);
            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotEmpty "

    /// <summary>
    ///     Checks whether the given <see cref="T:System.Guid" /> is not empty. An exception is thrown
    ///     otherwise.
    /// </summary>
    /// <param name="validator">
    ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///     Thrown when the given value of the specified <paramref name="validator" /> is empty.
    /// </exception>
    public static IArgumentValidator<Guid> IsNotEmpty(this IArgumentValidator<Guid> validator,
                                                      string? conditionDescription = null)
    {
        if (Guid.Empty.Equals(validator.Argument.Value))
        {
            string msg = MessageBuilder.Combine(validator.Argument,
                                                conditionDescription,
                                                StringRes.GuidShouldNotBeEmpty,
                                                false);
            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}