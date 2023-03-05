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

namespace Talegen.Common.Models.Server.Configuration
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// This class contains common synchronization settings for all server and API programs.
    /// </summary>
    public class SyncClientSettings : IOAuthClientSettings
    {
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        public string ClientId { get; set; } = "scim_client";

        /// <summary>
        /// Gets or sets the Identity API Uri.
        /// </summary>
        public Uri IdentityApiUri { get; set; } = default(Uri);

        /// <summary>
        /// Gets or sets an API secret key.
        /// </summary>
        public string Secret { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the identity scopes.
        /// </summary>
        /// <value>The identity scopes.</value>
        public List<string> Scopes { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SyncClientSettings" /> is enabled.
        /// </summary>
        /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the API suffix is added to the domain key sub-domain name.
        /// </summary>
        public bool ApplyResourceSubDomainApiSuffix { get; set; }

        /// <summary>
        /// Gets or sets the developer override for a logout domain with port.
        /// </summary>
        public string DeveloperLogoutUriTemplate { get; set; } = string.Empty;
    }
}