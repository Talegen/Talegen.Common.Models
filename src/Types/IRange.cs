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

namespace Talegen.Common.Models.Types
{
    /// <summary>
    /// This interface class is used to implement a range class.
    /// </summary>
    /// <typeparam name="T">Contains the type of data for the range.</typeparam>
    public interface IRange<T>
    {
        /// <summary>
        /// Gets or sets the start.
        /// </summary>
        /// <value>The start.</value>
        T Start { get; }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        T End { get; }

        /// <summary>
        /// Includes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        bool Includes(T value);

        /// <summary>
        /// Includes the specified range.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns></returns>
        bool Includes(IRange<T> range);
    }
}