﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Api.Common.Http;

namespace Api.Controllers
{
    /// <summary>
    /// Base API controller providing custom error handling.
    /// </summary>
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        protected readonly ISender _mediator;

        protected ApiController(ISender mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Returns a problem result based on a list of errors.
        /// </summary>
        /// <param name="errors">The list of errors.</param>
        /// <returns>An IActionResult representing the problem result.</returns>
        protected IActionResult Problem(List<Error> errors)
        {
            if (errors.Count is 0)
            {
                return Problem();
            }

            if (errors.All(error => error.Type == ErrorType.Validation))
            {
                return ValidationProblem(errors);
            }

            HttpContext.Items[HttpContextItemKeys.Errors] = errors;

            return Problem(errors[0]);
        }

        /// <summary>
        /// Returns a problem result based on a single error.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns>An IActionResult representing the problem result.</returns>
        private IActionResult Problem(Error error)
        {
            var statusCode = error.Type switch
            {
                ErrorType.Conflict => StatusCodes.Status409Conflict,
                ErrorType.Validation => StatusCodes.Status400BadRequest,
                ErrorType.NotFound => StatusCodes.Status404NotFound,
                _ => StatusCodes.Status500InternalServerError,
            };

            return Problem(statusCode: statusCode, title: error.Description);
        }

        /// <summary>
        /// Returns a validation problem result based on a list of errors.
        /// </summary>
        /// <param name="errors">The list of validation errors.</param>
        /// <returns>An IActionResult representing the validation problem result.</returns>
        private IActionResult ValidationProblem(List<Error> errors)
        {
            var modelStateDictionary = new ModelStateDictionary();

            foreach (var error in errors)
            {
                modelStateDictionary.AddModelError(error.Code, error.Description);
            }

            return ValidationProblem(modelStateDictionary);
        }
    }
}
