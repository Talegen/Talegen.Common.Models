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
    using System.Text;

    /// <summary>
    /// This interface contains the minimum implementation of server to server OAuth connection settings.
    /// </summary>
    public interface IOAuthClientSettings
    {
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Identity API Uri.
        /// </summary>
        Uri IdentityApiUri { get; set; }

        /// <summary>
        /// Gets or sets an API secret key.
        /// </summary>
        string Secret { get; set; }

        /// <summary>
        /// Gets or sets the identity scopes.
        /// </summary>
        /// <value>The identity scopes.</value>
        List<string> Scopes { get; set; }
    }
}