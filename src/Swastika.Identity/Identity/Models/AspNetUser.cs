﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Http;
using Swastika.Identity.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;

namespace Swastika.Identity.Models
{
    public class AspNetUser : IUser
    {
        /// <summary>
        /// The accessor{CC2D43FA-BBC4-448A-9D0B-7B57ADF2655C}
        /// </summary>
        private readonly IHttpContextAccessor _accessor;

        /// <summary>
        /// Initializes a new instance of the <see cref="AspNetUser" /> class.
        /// </summary>
        /// <param name="accessor">The accessor.</param>
        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name => _accessor.HttpContext.User.Identity.Name;

        /// <summary>
        /// Determines whether this instance is authenticated.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is authenticated; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        /// <summary>
        /// Gets the claims identity.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }
    }
}