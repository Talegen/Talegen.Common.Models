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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Contains an enumerated list of role types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RoleTypes
    {
        /// <summary>
        /// System Roles Cannot be Deleted.
        /// </summary>
        System,

        /// <summary>
        /// User Defined Roles.
        /// </summary>
        Defined
    }

    /// <summary>
    /// This class represents a minimal representation of a security role.
    /// </summary>
    public class MinimalRoleModel : MicroRoleModel
    {
        /// <summary>
        /// Gets or sets the role description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the type of the role.
        /// </summary>
        /// <value>The type of the role.</value>
        public RoleTypes RoleType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the role is a system role and cannot be deleted.
        /// </summary>
        public bool Deleteable { get; set; }
    }
}