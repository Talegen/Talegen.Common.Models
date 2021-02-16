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

namespace Talegen.Common.Models.Shared.Queries
{
    using System;
    using Talegen.Common.Core.Extensions;

    /// <summary>
    /// This class contains parameters passed to the query for filtering.
    /// </summary>
    public class PaginatedQueryRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        public PaginatedQueryRequestModel()
            : this(25)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryRequestModel" /> class.
        /// </summary>
        /// <param name="maxPageSize">Contains the maximum page size.</param>
        /// <param name="currentPage">Contains an optional current page number.</param>
        public PaginatedQueryRequestModel(int maxPageSize, int currentPage = 1)
        {
            this.Page = currentPage;
            this.Limit = maxPageSize;
            this.Sort = Array.Empty<string>();
            this.Dir = Array.Empty<SortDirection>();
        }

        /// <summary>
        /// Gets or sets current page number.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the result limit.
        /// </summary>
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the name of the column to sort by.
        /// </summary>
        public string[] Sort { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        public SortDirection[] Dir { get; set; }
    }
}