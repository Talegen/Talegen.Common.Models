/*
 *
 * (c) Copyright Talegen, LLC.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/

namespace Talegen.Common.Models.Shared
{
    using System;
    using Talegen.Common.Core.Errors;

    /// <summary>
    /// This class represents an error message within the <see cref="ErrorResponseModel" /> class.
    /// </summary>
    public class ErrorModel : IErrorMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorModel" /> class.
        /// </summary>
        public ErrorModel()
            : this(string.Empty, ErrorType.Warning, DateTime.UtcNow, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorModel" /> class.
        /// </summary>
        /// <param name="message">Contains the error message text.</param>
        /// <param name="type">Contains the error message type.</param>
        /// <param name="eventDate">Contains the date time when the error was created.</param>
        /// <param name="stackTrace">Contains an error stack trace message.</param>
        /// <param name="propertyName">Contains the property name for validation errors.</param>
        public ErrorModel(string message, ErrorType type, DateTime eventDate, string stackTrace, string propertyName = "")
        {
            this.Message = message;
            this.ErrorType = type;
            this.PropertyName = propertyName;
            this.StackTrace = stackTrace;
            this.EventDate = eventDate;
        }

        /// <summary>
        /// Gets or sets the message error type.
        /// </summary>
        public ErrorCategory ErrorCategory { get; set; }

        /// <summary>
        /// Gets or sets a suggested error code.
        /// </summary>
        public int SuggestedErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error message type.
        /// </summary>
        public ErrorType ErrorType { get; set; }

        /// <summary>
        /// Gets or sets the error message text.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a related property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets the date time when the error was generated.
        /// </summary>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the error stack trace generated if any.
        /// </summary>
        public string StackTrace { get; set; }
    }
}