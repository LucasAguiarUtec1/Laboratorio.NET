using Data_Access_Layer.EF_Models;
using DataAccessLayer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI;

Console.WriteLine("################################################################");
Console.WriteLine("# Init Main                                                   #");
Console.WriteLine("################################################################");

Console.WriteLine("Esperando 3 segundos para que la base de datos se inicie correctamente");
System.Threading.Thread.Sleep(3000);
Console.WriteLine("Espera finalizada");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Define Configuration Manager to access appsettings.json
    ConfigurationManager configuration = builder.Configuration;

    // For Entity Framework
    builder.Services.AddDbContext<DBContextCore>();

    // For Identity
    builder.Services.AddIdentity<Usuarios, IdentityRole>(options => {
        // N�mero m�ximo de intentos de inicio de sesi�n fallidos
        options.Lockout.MaxFailedAccessAttempts = 5;
        // Tiempo que la cuenta queda bloqueada despu�s de alcanzar el n�mero m�ximo de intentos de inicio de sesi�n fallidos
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
        // Requerimientos de la password
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireDigit = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequiredLength = 8;
    })
    .AddEntityFrameworkStores<DBContextCore>()
    .AddDefaultTokenProviders();

    #region Authentication
    // Adding Authentication
    string? JWT_SECRET = Environment.GetEnvironmentVariable("JWT_SECRET");
    if (string.IsNullOrEmpty(JWT_SECRET))
        JWT_SECRET = configuration["JWT:Secret"] == null ? "JWTKEY" : configuration["JWT:Secret"];

    builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    // Adding Jwt Bearer
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidAudience = configuration["JWT:ValidAudience"],
            ValidIssuer = configuration["JWT:ValidIssuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWT_SECRET == null ? "" : JWT_SECRET)),
            ClockSkew = TimeSpan.FromMinutes(5)
        };
    });
    #endregion

    // Add services to the container.
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Listen only on HTTP
    builder.WebHost.UseUrls("http://*:80");

    /********************************************************************************************************/
    /** Add Dependencies                                                                                   **/
    /********************************************************************************************************/
    #region  Inyecci�n de dependencias

    // DALs
    //builder.Services.AddTransient<IDAL_Personas, DAL_Personas_EF>();

    // BLs
    //builder.Services.AddTransient<IBL_Personas, BL_Personas>();

    #endregion

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    //if (app.Environment.IsDevelopment())
    //{
        app.UseSwagger();
        app.UseSwaggerUI();
    //}

    StartUp.UpdateDatabase(app);
    StartUp.InitializeDatabase(app);

    app.UseAuthorization();

    app.MapControllers();

    UpdateDatabase();

    app.Run();

}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


void UpdateDatabase()
{
    using (var context = new DataAccessLayer.DBContextCore())
    {
        context?.Database.Migrate();
    }
}