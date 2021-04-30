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

namespace Talegen.Common.Models.Extensions
{
    using System;
    using System.Security.Claims;
    using Newtonsoft.Json;
    using Talegen.Common.Models.Contacts;
    using Talegen.Common.Models.Extensions.Internal;

    /// <summary>
    /// This extensions class contains extension methods to enhance the use of the Contact models.
    /// </summary>
    public static class ContactExtensions
    {
        /// <summary>
        /// The JWT address claim type.
        /// </summary>
        public const string JwtAddressClaimType = "address";

        /// <summary>
        /// This extension method converts a JWT address claim to a <see cref="Address" /> model object.
        /// </summary>
        /// <param name="claim">The claim containing the address information.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Exception is thrown if <paramref name="claim" /> is null.</exception>
        public static Address ToAddress(this Claim claim)
        {
            Address result = null;

            if (claim == null)
            {
                throw new ArgumentNullException(nameof(claim));
            }

            // is a JWT address claim
            if (claim.Type == JwtAddressClaimType && !string.IsNullOrWhiteSpace(claim.Value))
            {
                JwtAddressModel jwtModel = JsonConvert.DeserializeObject<JwtAddressModel>(claim.Value);

                if (jwtModel != null)
                {
                    string[] streetLines = jwtModel.StreetAddress.Split('\n');

                    result = new Address
                    {
                        Street1 = streetLines != null ? streetLines[0].Replace("\r", string.Empty).Replace("\n", string.Empty) : string.Empty,
                        Street2 = streetLines != null && streetLines.Length > 1 ? streetLines[1].Replace("\r", string.Empty).Replace("\n", string.Empty) : string.Empty,
                        City = jwtModel.Locality,
                        Country = jwtModel.Country,
                        PostalCode = jwtModel.PostalCode,
                        RegionState = jwtModel.Region,
                        Formatted = jwtModel.Formatted
                    };
                }
            }

            return result;
        }
    }
}