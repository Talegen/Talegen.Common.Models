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
    using System;

    /// <summary>
    /// This class represents a date range of a start date time and end date time.
    /// </summary>
    /// <seealso cref="IRange{DateTime}" />
    public class DateTimeRange : IRange<DateTime>
    {
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>The start date.</value>
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>The end date.</value>
        public DateTime End { get; set; }

        /// <summary>
        /// Includes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Includes(DateTime value)
        {
            return (this.Start <= value) && (value <= this.End);
        }

        /// <summary>
        /// Includes the specified range.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool Includes(IRange<DateTime> range)
        {
            return (this.Start <= range.Start) && (range.End <= this.End);
        }
    }
}