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

namespace Talegen.Common.Models.Server.Queries
{
    using System.Collections.Generic;

    /// <summary>
    /// This class defines the basic query result model for the paginated query.
    /// </summary>
    /// <typeparam name="TQueryModel">The type of the query result.</typeparam>
    public class PaginatedQueryResultModel<TQueryModel> : PaginatedQueryRequestModel
        where TQueryModel : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryResultModel{TQueryModel}" /> class.
        /// </summary>
        public PaginatedQueryResultModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedQueryResultModel{TQueryModel}" /> class.
        /// </summary>
        /// <param name="request">Contains the originating request model to populate query result properties.</param>
        public PaginatedQueryResultModel(PaginatedQueryRequestModel request)
            : base(request.Limit, request.Page)
        {
            this.Sort = request.Sort;
            this.Direction = request.Direction;
        }

        /// <summary>
        /// Gets or sets the total records.
        /// </summary>
        /// <value>The total records.</value>
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets the total pages.
        /// </summary>
        public int TotalPages => this.Limit > 0 ? (int)System.Math.Ceiling((double)this.TotalCount / this.Limit) : 0;

        /// <summary>
        /// Gets or sets the results of the model query.
        /// </summary>
        /// <value>The results.</value>
        public List<TQueryModel>? Results { get; set; }
    }
}