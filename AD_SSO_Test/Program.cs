using AD_SSO_Test.Services;
using Microsoft.AspNetCore.Server.IISIntegration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<ActiveDirectoryService>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    string? ldapUrl = configuration.GetValue<string>("LDAP:Url");
    if(ldapUrl != null) {
        return new ActiveDirectoryService(ldapUrl);
    }
    return new ActiveDirectoryService("error");
    
});
builder.Services.AddAuthentication(IISDefaults.AuthenticationScheme);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
