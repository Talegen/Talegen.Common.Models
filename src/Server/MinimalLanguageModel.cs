﻿/*
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

namespace Talegen.Common.Models.Server
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a minimal representation of a language within an application.
    /// </summary>
    public class MinimalLanguageModel
    {
        /// <summary>
        /// Gets or sets the unique language locale code.
        /// </summary>
        [Required]
        [MaxLength(5)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the language.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [available locale].
        /// </summary>
        /// <value><c>true</c> if [available locale]; otherwise, <c>false</c>.</value>
        public bool AvailableLocale { get; set; }
    }
}