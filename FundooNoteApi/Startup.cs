
using System;
using System.Text;
using BussinessManager.Interface;
using BussinessManager.Manager;
using FundooRepository.DBContext;
using FundooRepository.Interface;
using FundooRepository.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace FundooNoteApi
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
            services.AddDbContextPool<UserContext>(options => options.UseSqlServer(Configuration.GetConnectionString("UserDBConncetion")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccount, AccountManager>();
            services.AddTransient<INotes, NotesManager>();
            services.AddTransient<INotesRepository, NotesRepository>();
            services.AddTransient<ILabel, LabelManager>();
            services.AddTransient<ILabelRepository, LabelRepository>();
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "FUNDOO NOTES API", Version = "v1" });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = Configuration["Jwt:Issuer"],
                ValidAudience = Configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            };
        });
            services.AddAuthentication()
                .AddFacebook(facebookOptions =>
                {
                    facebookOptions.AppId = "363406137898633";
                    facebookOptions.AppSecret = "c9c61b14caf13579566d5a73062b34be";
                })
                .AddGoogle(googleOptions =>
                {
                    googleOptions.ClientId = "934977231069-8mtj2ihulrvr0eikc58cj5bdeepg6vui.apps.googleusercontent.com";
                    googleOptions.ClientSecret = "Xy3GTZL_cxsiyBf_bfbvvIwW";
                });
            //Add distributed cache service backed by Redis cache
            //services.AddDistributedRedisCache(o =>
            //{
               
            //    o.Configuration = "127.0.0.1:6379";
            //    o.InstanceName = "redis";
            //});        
        }       
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())

            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "FUNDOO NOTE API");
            });
          
            app.UseHttpsRedirection();
            app.UseAuthentication();
        
            app.UseMvc();
        }
    }
}
