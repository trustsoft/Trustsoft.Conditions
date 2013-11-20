﻿//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.IComparable{T}.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        #region " IsEqualTo "

        /// <summary>
        ///     Checks whether the given value is equal to the specified <paramref name="value"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="value"> The valid value to compare with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is not equal to <paramref name="value"/>.
        /// </exception>
        public static IArgumentValidator<T> IsEqualTo<T>(this IArgumentValidator<T> validator,
                                                         T value,
                                                         string conditionDescription = null) where T : IComparable<T>
        {
            if (validator.Argument.Value.CompareTo(value) != 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeEqualToX,
                                                    true,
                                                    value);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsGreaterOrEqual "

        /// <summary>
        ///     Checks whether the given value is greater or equal to the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller than <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsGreaterOrEqual<T>(this IArgumentValidator<T> validator,
                                                                T minValue,
                                                                string conditionDescription = null)
            where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(minValue) >= 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeGreaterThanOrEqualToX,
                                                    true,
                                                    minValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsGreaterThan "

        /// <summary>
        ///     Checks whether the given value is greater than the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to
        ///     <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsGreaterThan<T>(this IArgumentValidator<T> validator,
                                                             T minValue,
                                                             string conditionDescription = null)
            where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(minValue) > 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeGreaterThanX,
                                                    true,
                                                    minValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsInRange "

        /// <summary>
        ///     Checks whether the given value is between <paramref name="minValue"/> and
        ///     <paramref name="maxValue"/> (including those values). An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="maxValue"> The highest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is not in the specified range.
        /// </exception>
        public static IArgumentValidator<T> IsInRange<T>(this IArgumentValidator<T> validator,
                                                         T minValue,
                                                         T maxValue,
                                                         string conditionDescription = null) where T : IComparable<T>
        {
            T value = validator.Argument.Value;

            if (value.CompareTo(minValue) < 0 || value.CompareTo(maxValue) > 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeBetweenXAndY,
                                                    true,
                                                    minValue,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsLessOrEqual "

        /// <summary>
        ///     Checks whether the given value is smaller or equal to the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The highest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater than <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsLessOrEqual<T>(this IArgumentValidator<T> validator,
                                                             T maxValue,
                                                             string conditionDescription = null)
            where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(maxValue) <= 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeSmallerThanOrEqualToX,
                                                    true,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsLessThan "

        /// <summary>
        ///     Checks whether the given value is less than the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/>
        ///     is greater or equal to <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsLessThan<T>(this IArgumentValidator<T> validator,
                                                          T maxValue,
                                                          string conditionDescription = null) where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(maxValue) < 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeSmallerThanX,
                                                    true,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotEqualTo "

        /// <summary>
        ///     Checks whether the given value is unequal to the specified <paramref name="value"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="value"> The invalid value to compare with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is equal to <paramref name="value"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotEqualTo<T>(this IArgumentValidator<T> validator,
                                                            T value,
                                                            string conditionDescription = null) where T : IComparable<T>
        {
            if (validator.Argument.Value.CompareTo(value) == 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeUnequalToX,
                                                    true,
                                                    value);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotGreaterOrEqual "

        /// <summary>
        ///     Checks whether the given value is not greater or equal to the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/>
        ///     is greater or equal to <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotGreaterOrEqual<T>(this IArgumentValidator<T> validator,
                                                                   T maxValue,
                                                                   string conditionDescription = null)
            where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(maxValue) < 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeGreaterThanOrEqualToX,
                                                    true,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotGreaterThan "

        /// <summary>
        ///     Checks whether the given value is not greater than the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater than <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotGreaterThan<T>(this IArgumentValidator<T> validator,
                                                                T maxValue,
                                                                string conditionDescription = null)
            where T : IComparable<T>
        {
            if (!(validator.Argument.Value.CompareTo(maxValue) < 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeGreaterThanX,
                                                    true,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotInRange "

        /// <summary>
        ///     Checks whether the given value is not between <paramref name="minValue"/> and
        ///     <paramref name="maxValue"/> (including those values). An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest invalid value. </param>
        /// <param name="maxValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is in the specified range.
        /// </exception>
        public static IArgumentValidator<T> IsNotInRange<T>(this IArgumentValidator<T> validator,
                                                            T minValue,
                                                            T maxValue,
                                                            string conditionDescription = null) where T : IComparable<T>
        {
            T value = validator.Argument.Value;

            if (!(value.CompareTo(minValue) < 0 || value.CompareTo(maxValue) > 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeBetweenXAndY,
                                                    true,
                                                    minValue,
                                                    maxValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotLessOrEqual "

        /// <summary>
        ///     Checks whether the given value is not smaller or equal to the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to
        ///     <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotLessOrEqual<T>(this IArgumentValidator<T> validator,
                                                                T minValue,
                                                                string conditionDescription = null)
            where T : IComparable<T>
        {
            if (validator.Argument.Value.CompareTo(minValue) <= 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeSmallerThanOrEqualToX,
                                                    true,
                                                    minValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotLessThan "

        /// <summary>
        ///     Checks whether the given value is not less than the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller than <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotLessThan<T>(this IArgumentValidator<T> validator,
                                                             T minValue,
                                                             string conditionDescription = null)
            where T : IComparable<T>
        {
            if (validator.Argument.Value.CompareTo(minValue) < 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeSmallerThanX,
                                                    true,
                                                    minValue);
                validator.ErrorHandler.Post(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        #endregion
    }
}