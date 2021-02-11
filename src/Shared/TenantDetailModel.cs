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

namespace Vasont.Publisher.Models.Common
{
    /// <summary>
    /// This class represents the basic tenant information needed for the web application.
    /// </summary>
    public class TenantDetailModel
    {
        /// <summary>
        /// Gets or sets the domain key.
        /// </summary>
        public string DomainKey { get; set; }

        /// <summary>
        /// Gets or sets the tenant name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the support information about the Tenant.
        /// </summary>
        public string SupportInfo { get; set; }

        /// <summary>
        /// Gets or sets the support contact e-mail address for the Tenant.
        /// </summary>
        public string SupportEmail { get; set; }

        /// <summary>
        /// Gets or sets the default language to use for the tenant application.
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Gets or sets the server's session timeout in minutes.
        /// </summary>
        public int SessionTimeout { get; set; }

        /// <summary>
        /// Gets or sets the copyright of the tenant application.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the version of the tenant application.
        /// </summary>
        public string Version { get; set; }
    }
}