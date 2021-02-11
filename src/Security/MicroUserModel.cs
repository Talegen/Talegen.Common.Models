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

namespace Talegen.Common.Models.Security
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// This class contains the bare minimum properties to represent a user in the interface.
    /// </summary>
    public class MicroUserModel
    {
        /// <summary>
        /// Gets or sets the unique identity of the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the user's e-mail address.
        /// </summary>
        [StringLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        [StringLength(100)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        [StringLength(100)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets the user full name.
        /// </summary>
        public string FullName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}".Trim();
            }
        }

        /// <summary>
        /// Gets or sets the user name of the user.
        /// </summary>
        [StringLength(100)]
        public string UserName { get; set; }
    }
}