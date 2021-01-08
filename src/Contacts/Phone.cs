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

namespace Talegen.Common.Models.Contacts
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of phone types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PhoneTypes
    {
        /// <summary>
        /// Personal phone number
        /// </summary>
        Personal,

        /// <summary>
        /// Mobile phone number
        /// </summary>
        Mobile,

        /// <summary>
        /// Work phone number
        /// </summary>
        Work,

        /// <summary>
        /// A fax number.
        /// </summary>
        Fax,

        /// <summary>
        /// Other phone number
        /// </summary>
        Other
    }

    /// <summary>
    /// This class represents a minimum definition of a phone number.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>The country code.</value>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>The extension.</value>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public PhoneTypes Type { get; set; }
    }
}