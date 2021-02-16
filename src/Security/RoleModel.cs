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
    /// This model class represents a security role within the application.
    /// </summary>
    public class RoleModel : MinimalRoleModel
    {
        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the creating user.
        /// </summary>
        public MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the record last updated date time.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user model for the updating user.
        /// </summary>
        public MicroUserModel UpdatedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the role is automatically added to users when they are synchronized via the application subscription Redis channel.
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Gets or sets a list of user models assigned to this role.
        /// </summary>
        public List<MicroUserModel> Users { get; set; } = new List<MicroUserModel>();

        /// <summary>
        /// Gets or sets the claims assigned to the role.
        /// </summary>
        /// <value>The claims assigned to the role.</value>
        public Dictionary<string, string> Claims { get; set; } = new Dictionary<string, string>();
    }
}