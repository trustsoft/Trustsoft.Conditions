﻿// --------------------------------------------------------------------------------------------------------
// <auto-generated>
//     Runtime Version: 4.0.30319.42000
//     This code was generated by a T4 Template at 29-12-2024, 05:51:45.
//       
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;

    #endregion

    internal static class StringRes
    {
        #region " String Resource Names "

        internal const string GuidShouldBeEmpty = "GuidShouldBeEmpty";
        internal const string GuidShouldNotBeEmpty = "GuidShouldNotBeEmpty";
        internal const string LambdaXShouldHoldForValue = "LambdaXShouldHoldForValue";
        internal const string StringShouldBe1CharacterLong = "StringShouldBe1CharacterLong";
        internal const string StringShouldBeEmpty = "StringShouldBeEmpty";
        internal const string StringShouldBeLongerOrEqualTo1Character = "StringShouldBeLongerOrEqualTo1Character";
        internal const string StringShouldBeLongerOrEqualToXCharacters = "StringShouldBeLongerOrEqualToXCharacters";
        internal const string StringShouldBeLongerThan1Character = "StringShouldBeLongerThan1Character";
        internal const string StringShouldBeLongerThanXCharacters = "StringShouldBeLongerThanXCharacters";
        internal const string StringShouldBeNullOrEmpty = "StringShouldBeNullOrEmpty";
        internal const string StringShouldBeNullOrWhiteSpace = "StringShouldBeNullOrWhiteSpace";
        internal const string StringShouldBeShorterOrEqualTo1Character = "StringShouldBeShorterOrEqualTo1Character";
        internal const string StringShouldBeShorterOrEqualToXCharacters = "StringShouldBeShorterOrEqualToXCharacters";
        internal const string StringShouldBeShorterThan1Character = "StringShouldBeShorterThan1Character";
        internal const string StringShouldBeShorterThanXCharacters = "StringShouldBeShorterThanXCharacters";
        internal const string StringShouldBeXCharactersLong = "StringShouldBeXCharactersLong";
        internal const string StringShouldContainX = "StringShouldContainX";
        internal const string StringShouldEndWithX = "StringShouldEndWithX";
        internal const string StringShouldMatchPattern = "StringShouldMatchPattern";
        internal const string StringShouldNotBe1CharacterLong = "StringShouldNotBe1CharacterLong";
        internal const string StringShouldNotBeEmpty = "StringShouldNotBeEmpty";
        internal const string StringShouldNotBeNullOrEmpty = "StringShouldNotBeNullOrEmpty";
        internal const string StringShouldNotBeNullOrWhiteSpace = "StringShouldNotBeNullOrWhiteSpace";
        internal const string StringShouldNotBeXCharactersLong = "StringShouldNotBeXCharactersLong";
        internal const string StringShouldNotContainX = "StringShouldNotContainX";
        internal const string StringShouldNotEndWithX = "StringShouldNotEndWithX";
        internal const string StringShouldNotMatchPattern = "StringShouldNotMatchPattern";
        internal const string StringShouldNotStartWithX = "StringShouldNotStartWithX";
        internal const string StringShouldStartWithX = "StringShouldStartWithX";
        internal const string TheActualValueIsX = "TheActualValueIsX";
        internal const string ValueShouldBeAnEvenNumber = "ValueShouldBeAnEvenNumber";
        internal const string ValueShouldBeAnOddNumber = "ValueShouldBeAnOddNumber";
        internal const string ValueShouldBeANumber = "ValueShouldBeANumber";
        internal const string ValueShouldBeBetweenXAndY = "ValueShouldBeBetweenXAndY";
        internal const string ValueShouldBeEqualToX = "ValueShouldBeEqualToX";
        internal const string ValueShouldBeGreaterThanOrEqualToX = "ValueShouldBeGreaterThanOrEqualToX";
        internal const string ValueShouldBeGreaterThanX = "ValueShouldBeGreaterThanX";
        internal const string ValueShouldBeInfinity = "ValueShouldBeInfinity";
        internal const string ValueShouldBeNegativeInfinity = "ValueShouldBeNegativeInfinity";
        internal const string ValueShouldBeNull = "ValueShouldBeNull";
        internal const string ValueShouldBeOfTypeX = "ValueShouldBeOfTypeX";
        internal const string ValueShouldBePositiveInfinity = "ValueShouldBePositiveInfinity";
        internal const string ValueShouldBeSmallerThanOrEqualToX = "ValueShouldBeSmallerThanOrEqualToX";
        internal const string ValueShouldBeSmallerThanX = "ValueShouldBeSmallerThanX";
        internal const string ValueShouldBeTrue = "ValueShouldBeTrue";
        internal const string ValueShouldBeUnequalToX = "ValueShouldBeUnequalToX";
        internal const string ValueShouldBeValid = "ValueShouldBeValid";
        internal const string ValueShouldBeX = "ValueShouldBeX";
        internal const string ValueShouldNotBeANumber = "ValueShouldNotBeANumber";
        internal const string ValueShouldNotBeBetweenXAndY = "ValueShouldNotBeBetweenXAndY";
        internal const string ValueShouldNotBeGreaterThanOrEqualToX = "ValueShouldNotBeGreaterThanOrEqualToX";
        internal const string ValueShouldNotBeGreaterThanX = "ValueShouldNotBeGreaterThanX";
        internal const string ValueShouldNotBeInfinity = "ValueShouldNotBeInfinity";
        internal const string ValueShouldNotBeNegativeInfinity = "ValueShouldNotBeNegativeInfinity";
        internal const string ValueShouldNotBeNull = "ValueShouldNotBeNull";
        internal const string ValueShouldNotBeOfTypeX = "ValueShouldNotBeOfTypeX";
        internal const string ValueShouldNotBePositiveInfinity = "ValueShouldNotBePositiveInfinity";
        internal const string ValueShouldNotBeSmallerThanOrEqualToX = "ValueShouldNotBeSmallerThanOrEqualToX";
        internal const string ValueShouldNotBeSmallerThanX = "ValueShouldNotBeSmallerThanX";
        internal const string CollectionShouldBeEmpty = "CollectionShouldBeEmpty";
        internal const string CollectionShouldNotBeEmpty = "CollectionShouldNotBeEmpty";

        #endregion
        
        private static readonly ResourceManager resource;

        static StringRes()
        {
            resource = new ResourceManager(typeof(StringRes).Namespace + ".Resources.MessageStrings",
                                           typeof(StringRes).Assembly);
        }

        /// <summary>
        ///     Returns a string from the resource.
        /// </summary>
        /// <param name="resourceKey"> The resource key. </param>
        /// <returns> System.String. </returns>
        internal static string GetString(string resourceKey)
        {
            return resource.GetString(resourceKey);
        }

        /// <summary>
        ///     Returns a string from the resource and formats it with the given args in a culture-specific way.
        /// </summary>
        /// <param name="resourceKey"> The resource key. </param>
        /// <param name="args"> The arguments. </param>
        /// <returns> System.String. </returns>
        internal static string GetFormattedString(string resourceKey, params object[] args)
        {
            return GetStringInternal(resourceKey, args);
        }

        private static string GetStringInternal(string name, params object[] args)
        {
            string format = GetString(name);

            Debug.Assert(format != null, "resource.GetFormattedString() returned null for resourceKey=" + name);

            if (args == null)
            {
                return format;
            }

            return string.Format(CultureInfo.CurrentCulture, format, args);
        }
    }
}
