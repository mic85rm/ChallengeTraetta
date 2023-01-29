using ChallengeTraetta.Context;
using ChallengeTraetta.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ChallengeTraetta
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddHttpContextAccessor();
      services.AddDbContext<CompanyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Challenge")));

      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddJwtBearer(options =>
  {
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
      ValidateIssuer = true,
      ValidateAudience = true,
      ValidateLifetime = true,
      ValidateIssuerSigningKey = true,
      ValidIssuer = Configuration["Jwt:Issuer"],
      ValidAudience = Configuration["Jwt:Audience"],
      
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecretKey"])),
      ClockSkew = TimeSpan.Zero
    };
  });
      IdentityModelEventSource.ShowPII = true;
      services.AddAuthorization(config =>
      {
        config.AddPolicy(Policies.Admin, Policies.AdminPolicy());
        config.AddPolicy(Policies.User, Policies.UserPolicy());
      });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env,CompanyContext context)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      context.Seed();

     





      app.UseHttpsRedirection();

      app.UseRouting();
      app.UseAuthentication();
      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
