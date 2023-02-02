// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
      {
            new ApiResource("resource_catalog"){Scopes={"catalog_fullpermission"}},
      };


        public static IEnumerable<ApiScope> ApiScopes =>
           new ApiScope[]
           {
                new ApiScope("catalog_fullpermission","Catalog API için full erişim"),
           };
        public static IEnumerable<Client> Clients =>
           new Client[]
           {
                new Client
                {
                   ClientName=".Net Core",
                    ClientId="WebClient",
                    ClientSecrets= {new Secret("secret".Sha256())},
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes={ "catalog_fullpermission","photo_stock_fullpermission", "gateway_fullpermission", IdentityServerConstants.LocalApi.ScopeName }
                }
           };
    }
}