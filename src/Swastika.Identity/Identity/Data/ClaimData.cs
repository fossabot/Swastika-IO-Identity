﻿// Licensed to the Swastika I/O Foundation under one or more agreements.
// The Swastika I/O Foundation licenses this file to you under the GNU General Public License v3.0 license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Swastika.Identity.Data
{
    public static class IdentityBasedData
    {
        public static List<string> UserClaims { get; set; } = new List<string>
                                                            {
                                                                "Add User",
                                                                "Edit User",
                                                                "Delete User"
                                                            };
    }
}