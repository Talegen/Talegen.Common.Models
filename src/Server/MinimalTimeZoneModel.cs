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

namespace Talegen.Common.Models.Server
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class represents a minimal set of time zone model information for an application.
    /// </summary>
    public class MinimalTimeZoneModel
    {
        /// <summary>
        /// Gets or sets the time zone identity value.
        /// </summary>
        [MaxLength(100)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the time zone short name.
        /// </summary>
        [MaxLength(200)]
        public string ShortName { get; set; }
    }
}