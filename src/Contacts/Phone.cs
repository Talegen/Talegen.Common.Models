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

namespace Talegen.Common.Models.Contacts
{
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// Contains an enumerated list of phone types.
    /// </summary>
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
        public string? CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        [Phone]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>The extension.</value>
        public string? Extension { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public PhoneTypes Type { get; set; }

        /// <summary>
        /// Convert model to string.
        /// </summary>
        /// <returns>Returns the model string.</returns>
        public override string ToString()
        {
            return $"{this.CountryCode} {this.Number} {this.Extension}".Trim();
        }

        /// <summary>
        /// This method is used to determine if the phone number is valid.
        /// </summary>
        /// <returns>Returns a value indicating whether the phone number property is a valid phone number.</returns>
        public bool IsValid()
        {
            PhoneAttribute phoneAttribute = new PhoneAttribute();
            return !string.IsNullOrWhiteSpace(this.Number) && phoneAttribute.IsValid(this.Number); ;
        }
    }
}