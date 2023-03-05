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
    /// This enum contains cache type.
    /// </summary>
    public enum CacheType
    {
        /// <summary>
        /// The value indicates that memory cache should be used
        /// </summary>
        Memory,

        /// <summary>
        /// The value indicates that Redis cache should be used
        /// </summary>
        Redis
    }

    /// <summary>
    /// This class represents cache settings in the server config.
    /// </summary>
    public class CacheSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettings" /> class.
        /// </summary>
        public CacheSettings()
        {
            this.SubscriptionCacheLifeMinutes = 20;
            this.UserAppInfoLifeMinutes = 20;
            this.NamedSeatLicenseUseLifeMinutes = 2;
            this.ConcurrentSeatLicenseUseLifeMinutes = 2;
            this.SubscriptionCacheSlidingWindow = true;
            this.UserAppInfoCacheSlidingWindow = true;
        }

        /// <summary>
        /// Gets or sets the cache type
        /// </summary>
        public CacheType CacheType { get; set; } = CacheType.Memory;

        /// <summary>
        /// Gets or sets the application state time to live in minutes.
        /// </summary>
        public int SubscriptionCacheLifeMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the subscription information cache is a sliding window.
        /// </summary>
        public bool SubscriptionCacheSlidingWindow { get; set; }

        /// <summary>
        /// Gets or sets the user application subscription information time to live in minutes.
        /// </summary>
        public int UserAppInfoLifeMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user subscription information cache is a sliding window.
        /// </summary>
        public bool UserAppInfoCacheSlidingWindow { get; set; }

        /// <summary>
        /// Gets or sets the named seat license usage life in minutes.
        /// </summary>
        public int NamedSeatLicenseUseLifeMinutes { get; set; }

        /// <summary>
        /// Gets or sets the concurrent seat license usage life in minutes.
        /// </summary>
        public int ConcurrentSeatLicenseUseLifeMinutes { get; set; }
    }
}