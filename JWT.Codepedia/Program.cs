using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAuthentication(options =>
//        {
//            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//        }).AddJwtBearer(option =>
//        {
//            var Key = Encoding.UTF8.GetBytes(Configuration["JWT:Key"]);
//            option.SaveToken = true;
//            option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
//            {
//                ValidateIssuer = true,
//                ValidateAudience = false,
//                ValidateLifetime = true,
//                ValidateIssuerSigningKey = true,
//                ValidIssuer = Configuration["JWT:Issuer"],
//                ValidAudience = Configuration["JWT:Audience"],
//                IssuerSigningKey = new SymmetricSecurityKey(Key)
//            };
//        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
