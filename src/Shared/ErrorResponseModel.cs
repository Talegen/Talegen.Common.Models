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
    using System.Collections.Generic;

    /// <summary>
    /// This class is used as the Error Response Model from an application.
    /// </summary>
    public class ErrorResponseModel
    {
        /// <summary>
        /// Gets the error messages.
        /// </summary>
        public List<ErrorModel> Messages { get; } = new List<ErrorModel>();

        /// <summary>
        /// Gets or sets the failed ids.
        /// </summary>
        public List<long> FailedIds { get; set; } = new List<long>();

        /// <summary>
        /// Gets or sets a value indicating whether this instance has unhandled exception.
        /// </summary>
        /// <value><c>true</c> if this instance has unhandled exception; otherwise, <c>false</c>.</value>
        public bool HasUnhandledException { get; set; }
    }
}