// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace Identity.UI
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("brewery.read", "Read access on Brewery Api"),
                //new ApiScope("hr.read", "Read access on HumanResources Api"),
                new ApiScope("manage", "Write access")
                /*new ApiScope("scope1"),
                new ApiScope("scope2"),*/
            };

        public static IEnumerable<ApiResource> ApiResources =>
    new List<ApiResource>
    {
        new ApiResource("brewery", "Brewery API")
        {
            Scopes = { "brewery.read", "manage" },

        }
  
    };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                    {
                ClientId = "kwops.cli",
                ClientName = "KWops Command Line Interface",
                ClientSecrets = { new Secret("SuperSecretClientSecret".Sha256()) },
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris = { "http://localhost:7890/" }, //url waarna het jwt token wordt verstuurd.
                AllowOfflineAccess = true,
                AllowedScopes = { "openid", "profile", "Brewery.read","manage" } //added manage manual
                    }
            };
    }
}