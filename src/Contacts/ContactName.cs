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
    /// <summary>
    /// This class implements the minimum properties for a contact name.
    /// </summary>
    public class ContactName
    {
        /// <summary>
        /// Gets or sets the name of the sir.
        /// </summary>
        /// <value>The name of the sir.</value>
        public string PrefixTitle { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>The name of the middle.</value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the suffix title of the name name.
        /// </summary>
        /// <value>The suffix title of the name.</value>
        public string SuffixTitle { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName => $"{this.PrefixTitle} {this.FirstName} {this.MiddleName} {this.LastName} {this.SuffixTitle}".Trim().Replace("  ", " ");

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ContactName" /> is primary.
        /// </summary>
        /// <value><c>true</c> if primary; otherwise, <c>false</c>.</value>
        public bool Primary { get; set; }

        /// <summary>
        /// Returns the model as a string.
        /// </summary>
        /// <returns>Contains the model string.</returns>
        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}