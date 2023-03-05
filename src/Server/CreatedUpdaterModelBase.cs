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

namespace Talegen.Common.Models.Server
{
    using System;
    using Talegen.Common.Models.Security;

    /// <summary>
    /// This class contains basic created and updater properties for model records.
    /// </summary>
    public abstract class CreatedUpdaterModelBase
    {
        /// <summary>
        /// Gets or sets the record created date time.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record creator model object.
        /// </summary>
        public MicroUserModel CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the record last updated date time.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the record updater model object.
        /// </summary>
        public MicroUserModel UpdatedBy { get; set; }
    }
}