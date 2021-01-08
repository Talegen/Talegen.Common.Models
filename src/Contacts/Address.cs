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
    /// Contains an enumerated list of address types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
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
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or sets the secondary address street.
        /// </summary>
        /// <value>The secondary address street.</value>
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or sets the address city.
        /// </summary>
        /// <value>The address city.</value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the address state/region.
        /// </summary>
        /// <value>The state of the address state/region.</value>
        public string RegionState { get; set; }

        /// <summary>
        /// Gets or sets the address postal/zip code.
        /// </summary>
        /// <value>The state of the address postal/zip code.</value>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address country.
        /// </summary>
        /// <value>The address country.</value>
        public string Country { get; set; }

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
    }
}