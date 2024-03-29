﻿/*
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

namespace Talegen.Common.Models.Server
{
    /// <summary>
    /// This class represents a base for displaying a name value pair combination.
    /// </summary>
    /// <typeparam name="TDisplay">Contains the display data type.</typeparam>
    /// <typeparam name="TValue">Contains the value data type.</typeparam>
    public abstract class DisplayValuePair<TDisplay, TValue>
    {
        /// <summary>
        /// Gets or sets the pair display value.
        /// </summary>
        public TDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets the pair value.
        /// </summary>
        public TValue Value { get; set; }
    }
}