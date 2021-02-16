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

namespace Talegen.Common.Models.Security.Queries
{
    using Talegen.Common.Models.Shared.Queries;

    /// <summary>
    /// This class defines the administration user query filter model.
    /// </summary>
    /// <seealso cref="Talegen.Common.Models.Shared.Queries.PaginatedQueryRequestModel" />
    public class UserQueryFilterModel : PaginatedQueryRequestModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        /// <value>The search text.</value>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the search filter should show only active users.
        /// </summary>
        /// <value><c>true</c> if only active; otherwise, <c>false</c> and return all users.</value>
        public bool OnlyActive { get; set; } = true;
    }
}