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
    /// <summary>
    /// This class contains application settings for the Web API.
    /// </summary>
    public abstract class ServerSettingsBase
    {
        /// <summary>
        /// Gets or sets the cache related settings.
        /// </summary>
        public CacheSettings Cache { get; set; } = new CacheSettings();

        /// <summary>
        /// Gets or sets security settings.
        /// </summary>
        public SecuritySettings Security { get; set; } = new SecuritySettings();

        /// <summary>
        /// Gets or sets advanced settings.
        /// </summary>
        public AdvancedSettings Advanced { get; set; } = new AdvancedSettings();
    }
}