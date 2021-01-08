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
    using System.Collections.Generic;
    using System.Text;
    using Talegen.Common.Models.Metadata;

    /// <summary>
    /// Contains an enumerated list of gender types.
    /// </summary>
    public enum GenderTypes
    {
        /// <summary>
        /// No gender specified.
        /// </summary>
        None,

        /// <summary>
        /// Male gender.
        /// </summary>
        Male,

        /// <summary>
        /// Female gender.
        /// </summary>
        Female,

        /// <summary>
        /// Non-biological identity.
        /// </summary>
        Other
    }

    /// <summary>
    /// Contains an extended set of contact details.
    /// </summary>
    /// <seealso cref="Talegen.Common.Models.Contacts.Contact" />
    public class ContactDetails : Contact
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>The customer identifier.</value>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the nickname.
        /// </summary>
        /// <value>The nickname.</value>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the office.
        /// </summary>
        /// <value>The office.</value>
        public string Office { get; set; }

        /// <summary>
        /// Gets or sets the profession.
        /// </summary>
        /// <value>The profession.</value>
        public string Profession { get; set; }

        /// <summary>
        /// Gets or sets the name of the manager.
        /// </summary>
        /// <value>The name of the manager.</value>
        public string ManagerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the assistant.
        /// </summary>
        /// <value>The name of the assistant.</value>
        public string AssistantName { get; set; }

        /// <summary>
        /// Gets or sets the name of the spouse partner.
        /// </summary>
        /// <value>The name of the spouse partner.</value>
        public string SpousePartnerName { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>The children.</value>
        public string Children { get; set; }

        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>The birthday.</value>
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Gets or sets the anniversary.
        /// </summary>
        /// <value>The anniversary.</value>
        public DateTime? Anniversary { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>The gender.</value>
        public GenderTypes Gender { get; set; } = GenderTypes.None;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>The language.</value>
        public string Language { get; set; } = Defaults.DefaultLanguageCode;

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        public string TimeZone { get; set; } = Defaults.DefaultTimeZone;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}