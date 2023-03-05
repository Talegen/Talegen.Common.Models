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
    /// This class represents advanced configuration settings.
    /// </summary>
    public class AdvancedSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether the database auto-migration logic should execute on startup.
        /// </summary>
        public bool AutoMigrate { get; set; }

        /// <summary>
        /// Gets or sets the MinimumCompletionPortThreads count.
        /// </summary>
        public int MinimumCompletionPortThreads { get; set; } = 200;

        /// <summary>
        /// Gets or sets a value indicating whether the diagnostics page is available.
        /// </summary>
        public bool ShowDiagnostics { get; set; }
    }
}