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
    using System.Collections.Generic;

    /// <summary>
    /// This class represents a security user within the application.
    /// </summary>
    public class UserModel : MinimalUserModel
    {
        /// <summary>
        /// Gets or sets the date time when the account was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the creator user.
        /// </summary>
        public MinimalUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date time when the account was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the updating user.
        /// </summary>
        public MinimalUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets the user notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user account is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can be deleted. Typically set to true if the user model matches the current user. The current user
        /// cannot delete themselves.
        /// </summary>
        public bool Deletable { get; set; }

        /// <summary>
        /// Gets or sets a list of associated roles.
        /// </summary>
        public List<MicroRoleModel> Roles { get; set; } = new List<MicroRoleModel>();

        /// <summary>
        /// Gets or sets the claims.
        /// </summary>
        /// <value>The claims.</value>
        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();
    }
}