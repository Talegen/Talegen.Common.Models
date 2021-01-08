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

namespace Talegen.Common.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains a static set of common default values.
    /// </summary>
    public static class Defaults
    {
        /// <summary>
        /// The default language code. English.
        /// </summary>
        public const string DefaultLanguageCode = "en";

        /// <summary>
        /// The default time zone offset.
        /// </summary>
        public const string DefaultTimeZone = "UTC";

        /// <summary>
        /// Available common titles.
        /// </summary>
        public static List<string> CommonNamePrefixes => new List<string> { "Dr.", "Miss", "Mr.", "Mrs.", "Ms.", "Prof.", "Sir" };
    }
}