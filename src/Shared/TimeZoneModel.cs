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
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a timezone model within an application.
    /// </summary>
    /// <seealso cref="Talegen.Common.Models.Shared.MinimalTimeZoneModel" />
    public class TimeZoneModel : MinimalTimeZoneModel
    {
        /// <summary>
        /// Gets or sets the long name of the time zone.
        /// </summary>
        [MaxLength(300)]
        public string LongName { get; set; }

        /// <summary>
        /// Gets or sets the numeric time offset.
        /// </summary>
        [Required]
        public double Offset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether if this is the default time zone.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the time zone is active.
        /// </summary>
        public bool Active { get; set; }
    }
}