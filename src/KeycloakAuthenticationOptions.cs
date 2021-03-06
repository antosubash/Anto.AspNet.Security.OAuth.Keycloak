/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace AspNet.Security.OAuth.Keycloak
{
    /// <summary>
    /// Defines a set of options used by <see cref="KeycloakAuthenticationHandler"/>.
    /// </summary>
    public class KeycloakAuthenticationOptions : OAuthOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeycloakAuthenticationOptions"/> class.
        /// </summary>
        public KeycloakAuthenticationOptions()
        {
            ClaimsIssuer = KeycloakAuthenticationDefaults.Issuer;
            CallbackPath = KeycloakAuthenticationDefaults.CallbackPath;

            AuthorizationEndpoint = KeycloakAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = KeycloakAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = KeycloakAuthenticationDefaults.UserInformationEndpoint;
            // TODO Add any required scopes
            Scope.Add("openid");
            Scope.Add("email");
            Scope.Add("roles");
            // TODO Map any claims
            ClaimActions.MapAll();
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "sub");
            ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
            ClaimActions.MapJsonKey(ClaimTypes.GivenName, "given_name");
            ClaimActions.MapJsonKey(ClaimTypes.Role, "roles");

        }

        public string BaseUrl { get; set; }
    }
}
