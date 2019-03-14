﻿namespace MyTested.AspNetCore.Mvc.Builders.ActionResults.File
{
    using Builders.Base;
    using Exceptions;
    using Internal;
    using Internal.TestContexts;
    using Microsoft.AspNetCore.Mvc;
    using Utilities.Extensions;
    using Utilities.Validators;

    /// <summary>
    /// Base class for all test builders with file result.
    /// </summary>
    /// <typeparam name="TFileResult">Type inheriting <see cref="FileResult"/>.</typeparam>
    public abstract class BaseFileTestBuilder<TFileResult> :
        BaseTestBuilderWithActionResult<TFileResult>
        where TFileResult : FileResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFileTestBuilder{TFileResult}"/> class.
        /// </summary>
        /// <param name="testContext"><see cref="ControllerTestContext"/> containing data about the currently executed assertion chain.</param>
        protected BaseFileTestBuilder(ControllerTestContext testContext)
            : base(testContext)
        {
        }
        
        /// <summary>
        /// Validates whether file result has the provided content type.
        /// </summary>
        /// <param name="contentType">Content type as string.</param>
        protected void ValidateContentType(string contentType)
        {
            ContentTypeValidator.ValidateContentType(
                this.ActionResult,
                contentType,
                this.ThrowNewFileResultAssertionException);
        }

        /// <summary>
        /// Validates whether file result has the provided file download name.
        /// </summary>
        /// <param name="fileDownloadName">File download name as string.</param>
        protected void ValidateFileDownloadName(string fileDownloadName)
        {
            var actualFileDownloadName = this.ActionResult.FileDownloadName;
            if (fileDownloadName != actualFileDownloadName)
            {
                this.ThrowNewFileResultAssertionException(
                    nameof(this.ActionResult.FileDownloadName),
                    $"to be {fileDownloadName.GetErrorMessageName()}",
                    $"instead received {(actualFileDownloadName != string.Empty ? $"'{actualFileDownloadName}'" : "empty string")}");
            }
        }

        /// <summary>
        /// Throws new FireResultAssertionException.
        /// </summary>
        /// <param name="propertyName">Failed property name.</param>
        /// <param name="expectedValue">Expected property value.</param>
        /// <param name="actualValue">Actual property value.</param>
        protected void ThrowNewFileResultAssertionException(string propertyName, string expectedValue, string actualValue)
            => throw new FileResultAssertionException(string.Format(
                ExceptionMessages.ActionResultFormat,
                this.TestContext.ExceptionMessagePrefix,
                "file",
                propertyName,
                expectedValue,
                actualValue));
    }
}
