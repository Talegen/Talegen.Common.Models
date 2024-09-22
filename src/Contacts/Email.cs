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
    using System.ComponentModel.DataAnnotations;
    
    /// <summary>
    /// Contains an enumerated list of phone types.
    /// </summary>
    
    public enum EmailTypes
    {
        /// <summary>
        /// Personal e-mail address
        /// </summary>
        Personal,

        /// <summary>
        /// Work e-mail address
        /// </summary>
        Work,

        /// <summary>
        /// Support contact e-mail address
        /// </summary>
        Support,

        /// <summary>
        /// Other e-mail address
        /// </summary>
        Other
    }

    /// <summary>
    /// This class represents a contact e-mail address.
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>The email address.</value>
        [EmailAddress]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public EmailTypes Type { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            // format e-mail address based on populated properties.
            string email = this.Address;

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                this.Name.Replace("\"", "'");
                string name = this.Name.Contains(" ") ? $"\"{ this.Name}\"" : this.Name;
                email = $"{name} <{this.Address}>";
            }

            return email;
        }

        /// <summary>
        /// This method is used to determine if the e-mail address is valid.
        /// </summary>
        /// <returns>Returns a value indicating whether the address is valid.</returns>
        public bool IsValid()
        {
            EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();
            return !string.IsNullOrWhiteSpace(this.Address) && emailAddressAttribute.IsValid(this.Address);
        }
    }
}