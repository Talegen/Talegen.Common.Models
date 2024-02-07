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
    /// This interface implements the minimum properties for identification
    /// </summary>
    public interface ISubjectIdentity<TKey> 
    {
        /// <summary>
        /// Gets or sets the unique identity of the subject.
        /// </summary>
        TKey Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the subject.
        /// </summary>
        string Name { get; set; }
    }
}