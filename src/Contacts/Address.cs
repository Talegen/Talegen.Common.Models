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
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Contains an enumerated list of address types.
    /// </summary>

    public enum AddressTypes
    {
        /// <summary>
        /// A home address.
        /// </summary>
        Home,

        /// <summary>
        /// A work address.
        /// </summary>
        Work,

        /// <summary>
        /// A business address.
        /// </summary>
        Business,

        /// <summary>
        /// Other type of address.
        /// </summary>
        Other
    }

    /// <summary>
    /// Contains an enumerated list of commerce address types
    /// </summary>
    public enum CommerceAddressTypes
    {
        /// <summary>
        /// The billing address.
        /// </summary>
        Billing,

        /// <summary>
        /// The mailing address.
        /// </summary>
        Mailing
    }

    /// <summary>
    /// This class represents the basic postal address for an entity.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the primary address street.
        /// </summary>
        /// <value>The primary address street.</value>
        public string? Street1 { get; set; }

        /// <summary>
        /// Gets or sets the secondary address street.
        /// </summary>
        /// <value>The secondary address street.</value>
        public string? Street2 { get; set; }

        /// <summary>
        /// Gets or sets the address city.
        /// </summary>
        /// <value>The address city.</value>
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the address state/region.
        /// </summary>
        /// <value>The state of the address state/region.</value>
        public string? RegionState { get; set; }

        /// <summary>
        /// Gets or sets the address postal/zip code.
        /// </summary>
        /// <value>The state of the address postal/zip code.</value>
        public string? PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address country.
        /// </summary>
        /// <value>The address country.</value>
        public string? Country { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public AddressTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the type of the commerce.
        /// </summary>
        /// <value>The type of the commerce.</value>
        public CommerceAddressTypes CommerceType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Address" /> is primary.
        /// </summary>
        /// <value><c>true</c> if primary; otherwise, <c>false</c>.</value>
        public bool Primary { get; set; }

        /// <summary>
        /// Converts to string formatted.
        /// </summary>
        /// <returns></returns>
        public string ToStringFormatted()
        {
            string formatted = string.Empty;

            // build formatted text out
            if (!string.IsNullOrWhiteSpace(this.Street1))
            {
                formatted = this.Street1 + Environment.NewLine;
            }

            if (!string.IsNullOrWhiteSpace(this.Street2))
            {
                formatted += this.Street2 + Environment.NewLine;
            }

            string localityRegionPostal = string.Empty;

            if (!string.IsNullOrWhiteSpace(this.City))
            {
                localityRegionPostal = this.City;
            }

            if (!string.IsNullOrWhiteSpace(this.RegionState))
            {
                localityRegionPostal += ", " + this.RegionState;
            }

            if (!string.IsNullOrWhiteSpace(this.PostalCode))
            {
                localityRegionPostal += " " + this.PostalCode;
            }

            formatted += localityRegionPostal + Environment.NewLine;

            if (!string.IsNullOrWhiteSpace(this.Country))
            {
                formatted += this.Country + Environment.NewLine;
            }
            
            return formatted;
        }

        /// <summary>
        /// Gets or sets the formatted.
        /// </summary>
        /// <value>
        /// Gets the Full mailing address, formatted for display or use on a mailing label.This field MAY contain multiple lines, separated by
        /// newlines.Newlines can be represented either as a carriage return/line feed pair ("\r\n") or as a single line feed character("\n").
        /// </value>
        [JsonIgnore]
        public string Formatted => this.ToStringFormatted();
    }
}