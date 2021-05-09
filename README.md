# Anto.AspNet.Security.OAuth.Keycloak
 
## Install 

```bash
<PackageReference Include="Anto.AspNet.Security.OAuth.Keycloak" Version="0.0.1" />
```

## Add to services

```cs
            context.Services
                .AddAuthentication()
                .AddKeycloak(options =>
                {
                    options.SignInScheme = IdentityConstants.ExternalScheme;
                    options.ClientId = "yourclientid";
                    options.ClientSecret = "yoursecret";
                    options.BaseUrl = "{domain}/auth/realms/{realmname}";
                    options.SaveTokens = true;
                })
```
