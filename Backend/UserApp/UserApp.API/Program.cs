using UserApp.Services;

namespace UserApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // tipo de app que estamos haciendo
            var builder = WebApplication.CreateBuilder(args);
            
            // Agregar servicios al contenedor
            builder.Services.AddControllers();

            #region INYECCION DE DEPENDENCIAS PROPIAS
            // Agregar db context de la capa DAL
            builder.Services.AddDbContext<DAL.AppDbContext>();

            // caoa de dependencias Service
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IGroupService, GroupService>();
            #endregion

            // para aprender como configurar Swagger https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            var app = builder.Build();

            // configura el pipeline de consultas HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}