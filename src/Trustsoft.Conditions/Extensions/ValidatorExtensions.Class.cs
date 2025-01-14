﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ValidatorExtensions.Class.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>20.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;

using Trustsoft.Conditions.Internals;

public static partial class ValidatorExtensions
{
    #region " IsNotNull "

    /// <summary>
    ///   Checks whether the given value is not is <see langword="null" />.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of value of the argument contained in the specified <paramref name="validator" />.
    /// </typeparam>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the argument's value
    ///   of the specified <paramref name="validator" /> is <see langword="null" />.
    /// </exception>
    public static IArgumentValidator<T> IsNotNull<T>(this IArgumentValidator<T> validator,
                                                     string? conditionDescription = null) where T : class?
    {
        if (validator.Argument.Value == null)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldNotBeNull,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotOfType "

    /// <summary>
    ///   Checks whether the given value is not of specified <paramref name="type" />.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of value of the argument contained in the specified <paramref name="validator" />.
    /// </typeparam>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="type"> The type. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the argument's value of the specified
    ///   <paramref name="validator" /> is of specified <paramref name="type" />.
    /// </exception>
    public static IArgumentValidator<T> IsNotOfType<T>(this IArgumentValidator<T> validator,
                                                       Type type,
                                                       string? conditionDescription = null) where T : class?
    {
        T value = validator.Argument.Value;

        if (value != null && type.IsInstanceOfType(value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldNotBeOfTypeX,
                                             false,
                                             type);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNull "

    /// <summary>
    ///   Checks whether the given value is <see langword="null" />.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of value of the argument contained in the specified <paramref name="validator" />.
    /// </typeparam>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the argument's value of
    ///   the specified <paramref name="validator" /> is not <see langword="null" />.
    /// </exception>
    public static IArgumentValidator<T> IsNull<T>(this IArgumentValidator<T> validator,
                                                  string? conditionDescription = null) where T : class?
    {
        if (validator.Argument.Value != null)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldBeNull,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsOfType "

    /// <summary>
    ///   Checks whether the given value is of specified <paramref name="type" />.
    /// </summary>
    /// <typeparam name="T">
    ///   The type of value of the argument contained in the specified <paramref name="validator" />.
    /// </typeparam>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="type"> The type to check for. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the argument's value of the
    ///   <paramref name="validator" /> is not of specified <paramref name="type" />.
    /// </exception>
    public static IArgumentValidator<T> IsOfType<T>(this IArgumentValidator<T> validator,
                                                    Type type,
                                                    string? conditionDescription = null) where T : class?
    {
        var value = validator.Argument.Value;

        if (value != null && !type.IsInstanceOfType(value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldBeOfTypeX,
                                             false,
                                             type);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}