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

    /// <summary>
    /// This class represents a user that is assigned to a role. It is a stripped down version of the user and returns only essential information related to the
    /// user for role associations.
    /// </summary>
    public class MinimalUserModel : MicroUserModel
    {
        /// <summary>
        /// Gets or sets the user's desired language.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the user's time zone.
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets a value indicating whether the user is locked.
        /// </summary>
        public bool Locked => this.LockExpirationDate.HasValue;

        /// <summary>
        /// Gets or sets the lock expiration date.
        /// </summary>
        public DateTime? LockExpirationDate { get; set; }
    }
}