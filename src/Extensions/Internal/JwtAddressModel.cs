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

namespace Talegen.Common.Models.Extensions.Internal
{
    using System;
    using System.Text.Json.Serialization;
    using Talegen.Common.Models.Contacts;

    /// <summary>
    /// This class represents a JWT address model for use in translation to a <see cref="Address" /> model.
    /// </summary>
    internal class JwtAddressModel
    {
        private string formattedText;

        /// <summary>
        /// Gets or sets the formatted.
        /// </summary>
        /// <value>
        /// Gets or sets the Full mailing address, formatted for display or use on a mailing label.This field MAY contain multiple lines, separated by
        /// newlines.Newlines can be represented either as a carriage return/line feed pair ("\r\n") or as a single line feed character("\n").
        /// </value>
        [JsonPropertyName("formatted")]
        public string Formatted
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.formattedText))
                {
                    // build formatted text out
                    if (!string.IsNullOrWhiteSpace(this.StreetAddress))
                    {
                        this.formattedText = this.StreetAddress + Environment.NewLine;
                    }

                    string localityRegionPostal = string.Empty;

                    if (!string.IsNullOrWhiteSpace(this.Locality))
                    {
                        localityRegionPostal = this.Locality;
                    }

                    if (!string.IsNullOrWhiteSpace(this.Region))
                    {
                        localityRegionPostal += ", " + this.Region;
                    }

                    if (!string.IsNullOrWhiteSpace(this.PostalCode))
                    {
                        localityRegionPostal += " " + this.PostalCode;
                    }

                    this.formattedText += localityRegionPostal + Environment.NewLine;

                    if (!string.IsNullOrWhiteSpace(this.Country))
                    {
                        this.formattedText += this.Country + Environment.NewLine;
                    }
                }

                return this.formattedText;
            }

            set
            {
                // set the formatted text.
                this.formattedText = value;
            }
        }

        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        /// <value>
        /// Full street address component, which MAY include house number, street name, Post Office Box, and multi-line extended street address information.This
        /// field MAY contain multiple lines, separated by newlines.Newlines can be represented either as a carriage return/line feed pair ("\r\n") or as a
        /// single line feed character("\n").
        /// </value>
        [JsonPropertyName("street_address")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        /// <value>The City or locality component.</value>
        [JsonPropertyName("locality")]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>The State, province, prefecture, or region component.</value>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The Zip code or postal code component.</value>
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country name component.</value>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}