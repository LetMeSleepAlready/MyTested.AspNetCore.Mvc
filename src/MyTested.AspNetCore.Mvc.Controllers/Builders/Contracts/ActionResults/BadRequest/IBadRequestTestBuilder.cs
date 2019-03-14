﻿namespace MyTested.AspNetCore.Mvc.Builders.Contracts.ActionResults.BadRequest
{
    using System.Collections.Generic;
    using Base;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Formatters;
    using Microsoft.Net.Http.Headers;

    /// <summary>
    /// Used for testing <see cref="BadRequestResult"/> and <see cref="BadRequestObjectResult"/>.
    /// </summary>
    public interface IBadRequestTestBuilder : IBaseTestBuilderWithStatusCodeResult<IAndBadRequestTestBuilder>
    {
        /// <summary>
        /// Tests whether no specific error is returned from the <see cref="BadRequestObjectResult"/>.
        /// </summary>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder WithNoError();

        /// <summary>
        /// Tests <see cref="BadRequestObjectResult"/> with specific text error message using test builder.
        /// </summary>
        /// <returns><see cref="IBadRequestErrorMessageTestBuilder"/>.</returns>
        IBadRequestErrorMessageTestBuilder WithErrorMessage();

        /// <summary>
        /// Tests <see cref="BadRequestObjectResult"/> with specific text error message provided by string.
        /// </summary>
        /// <param name="message">Expected error message.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder WithErrorMessage(string message);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the content type provided as string.
        /// </summary>
        /// <param name="contentType">Content type as string.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentType(string contentType);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the content type provided as <see cref="MediaTypeHeaderValue"/>.
        /// </summary>
        /// <param name="contentType">Content type as MediaTypeHeaderValue.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentType(MediaTypeHeaderValue contentType);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the same content types provided as collection of strings.
        /// </summary>
        /// <param name="contentTypes">Content types as collection of strings.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentTypes(IEnumerable<string> contentTypes);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the same content types provided as string parameters.
        /// </summary>
        /// <param name="contentTypes">Content types as string parameters.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentTypes(params string[] contentTypes);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the same content types provided as collection of <see cref="MediaTypeHeaderValue"/>.
        /// </summary>
        /// <param name="contentTypes">Content types as collection of <see cref="MediaTypeHeaderValue"/>.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentTypes(IEnumerable<MediaTypeHeaderValue> contentTypes);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the same content types provided as <see cref="MediaTypeHeaderValue"/> parameters.
        /// </summary>
        /// <param name="contentTypes">Content types as <see cref="MediaTypeHeaderValue"/> parameters.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingContentTypes(params MediaTypeHeaderValue[] contentTypes);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the provided output formatter.
        /// </summary>
        /// <param name="outputFormatter">Instance of <see cref="IOutputFormatter"/>.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingOutputFormatter(IOutputFormatter outputFormatter);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains output formatter of the provided type.
        /// </summary>
        /// <typeparam name="TOutputFormatter">Type of <see cref="IOutputFormatter"/>.</typeparam>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingOutputFormatterOfType<TOutputFormatter>()
            where TOutputFormatter : IOutputFormatter;

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the provided output formatters.
        /// </summary>
        /// <param name="outputFormatters">Collection of <see cref="IOutputFormatter"/>.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingOutputFormatters(IEnumerable<IOutputFormatter> outputFormatters);

        /// <summary>
        /// Tests whether <see cref="BadRequestObjectResult"/> contains the provided output formatters.
        /// </summary>
        /// <param name="outputFormatters"><see cref="IOutputFormatter"/> parameters.</param>
        /// <returns>The same <see cref="IAndBadRequestTestBuilder"/>.</returns>
        IAndBadRequestTestBuilder ContainingOutputFormatters(params IOutputFormatter[] outputFormatters);
    }
}
