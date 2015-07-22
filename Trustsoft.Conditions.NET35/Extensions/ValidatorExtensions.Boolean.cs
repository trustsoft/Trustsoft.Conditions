﻿//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Boolean.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>12.11.2013</date>
//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        /// <summary>
        ///     Checks whether the given <see cref="T:System.Boolean"/> is <c> true </c>. An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> false </c>.
        /// </exception>
        public static IArgumentValidator<bool> IsTrue(this IArgumentValidator<bool> validator,
                                                      string conditionDescription = null)
        {
            return IsValid(validator, true, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Boolean"/> is <c> false </c>. An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> true </c>.
        /// </exception>
        public static IArgumentValidator<bool> IsFalse(this IArgumentValidator<bool> validator,
                                                       string conditionDescription = null)
        {
            return IsValid(validator, false, conditionDescription);
        }

        private static IArgumentValidator<bool> IsValid(IArgumentValidator<bool> validator,
                                                        bool expected,
                                                        string conditionDescription)
        {
            if (validator.Argument.Value != expected)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeX,
                                                    false,
                                                    expected);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Boolean"/> is <c> true </c>. An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> false </c>.
        /// </exception>
        public static IArgumentValidator<bool?> IsTrue(this IArgumentValidator<bool?> validator,
                                                       string conditionDescription = null)
        {
            return IsValid(validator, true, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Boolean"/> is <c> false </c>. An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> true </c>.
        /// </exception>
        public static IArgumentValidator<bool?> IsFalse(this IArgumentValidator<bool?> validator,
                                                        string conditionDescription = null)
        {
            return IsValid(validator, false, conditionDescription);
        }

        private static IArgumentValidator<bool?> IsValid(IArgumentValidator<bool?> validator,
                                                         bool? expected,
                                                         string conditionDescription)
        {
            if (validator.Argument.Value != expected)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeX,
                                                    false,
                                                    expected);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}