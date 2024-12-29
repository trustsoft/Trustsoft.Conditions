﻿//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ErrorHandlerBase.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals;

internal abstract class ErrorHandlerBase<T> : IErrorHandler<T>
{
    #region " Implementation of IErrorHandler<T> "

    public IArgumentValidator<T> Validator { get; set; } = null!;

    public abstract void Post(ViolationType violationType, string message);

    public void Post(string message)
    {
        this.Post(ViolationType.Default, message);
    }

    #endregion
}