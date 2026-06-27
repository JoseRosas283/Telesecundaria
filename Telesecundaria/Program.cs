using Microsoft.EntityFrameworkCore;
using Telesecundaria.Persistence;
using Telesecundaria.Repositories.Implementations;
using Telesecundaria.Repositories.Interfaces;
using Telesecundaria.Services.Implementations;
using Telesecundaria.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString"))
           .LogTo(Console.WriteLine, LogLevel.Information)
           .EnableSensitiveDataLogging()
);

// Dependency Injection
builder.Services.AddScoped<IConvocatoriasRepository, ConvocatoriasRepository>();
builder.Services.AddScoped<IConvocatoriasService, ConvocatoriasService>();
builder.Services.AddScoped<IGaleriaImagenesRepository, GaleriaImagenesRepository>();
builder.Services.AddScoped<IGaleriaImagenesService, GaleriaImagenesService>();
builder.Services.AddScoped<IImagenService, ImagenService>();
builder.Services.AddScoped<IPublicacionesRepository, PublicacionesRepository>();
builder.Services.AddScoped<IPublicacionesService, PublicacionesService>();
builder.Services.AddScoped<IGruposRepository, GruposRepository>();
builder.Services.AddScoped<IGruposService, GruposService>();
builder.Services.AddScoped<IAsignacionGrupoRepository, AsignacionGrupoRepository>();
builder.Services.AddScoped<IAsignacionGrupoService, AsignacionGrupoService>();
builder.Services.AddScoped<ITutorAspiranteRepository, TutorAspiranteRepository>();
builder.Services.AddScoped<ITutorAspiranteService, TutorAspiranteService>();
builder.Services.AddScoped<IAspirantesRepository, AspirantesRepository>();
builder.Services.AddScoped<IAspirantesService, AspirantesService>();
builder.Services.AddScoped<ITipoDocumentosRepository, TipoDocumentosRepository>();
builder.Services.AddScoped<ITipoDocumentosService, TipoDocumentosService>();
builder.Services.AddScoped<IRequisitosRepository, RequisitosRepository>();
builder.Services.AddScoped<IRequisitosService, RequisitosService>();
builder.Services.AddScoped<IAdjuncionesRepository, AdjuncionesRepository>();
builder.Services.AddScoped<IAdjuncionesService, AdjuncionesService>();
builder.Services.AddScoped<IPdfService, PdfService>();
builder.Services.AddScoped<IAdjuncionesRepository, AdjuncionesRepository>();
builder.Services.AddScoped<IAdjuncionesService, AdjuncionesService>();
builder.Services.AddScoped<ICiclosEscolaresRepository, CiclosEscolaresRepository>();
builder.Services.AddScoped<ICiclosEscolaresService, CiclosEscolaresService>();
builder.Services.AddScoped<IInscripcionesRepository, InscripcionesRepository>();
builder.Services.AddScoped<IInscripcionesService, InscripcionesService>();
builder.Services.AddScoped<IPagosRepository, PagosRepository>();
builder.Services.AddScoped<IPagosService, PagosService>();
builder.Services.AddScoped<IRevisionesRepository, RevisionesRepository>();
builder.Services.AddScoped<IRevisionesService, RevisionesService>();
builder.Services.AddScoped<IDetalleRevisionRepository, DetalleRevisionRepository>();
builder.Services.AddScoped<IDetalleRevisionService, DetalleRevisionService>();
builder.Services.AddScoped<IRevisionesAceptadasRepository, RevisionesAceptadasRepository>();
builder.Services.AddScoped<IRevisionesAceptadasService, RevisionesAceptadasService>();
builder.Services.AddScoped<ICitasInscripcionRepository, CitasInscripcionRepository>();
builder.Services.AddScoped<ICitasInscripcionService, CitasInscripcionService>();
builder.Services.AddScoped<IAdjuncionesOriginalesRepository, AdjuncionesOriginalesRepository>();
builder.Services.AddScoped<IAdjuncionesOriginalesService, AdjuncionesOriginalesService>();
builder.Services.AddScoped<ITutoresRepository, TutoresRepository>();
builder.Services.AddScoped<ITutoresService, TutoresService>();
builder.Services.AddScoped<ITutoresAlumnosRepository, TutoresAlumnosRepository>();
builder.Services.AddScoped<ITutoresAlumnosService, TutoresAlumnosService>();
builder.Services.AddScoped<ITipoNotificacionesRepository, TipoNotificacionesRepository>();
builder.Services.AddScoped<ITipoNotificacionesService, TipoNotificacionesService>();
builder.Services.AddScoped<IDestinoNotificacionRepository, DestinoNotificacionRepository>();
builder.Services.AddScoped<IDestinoNotificacionService, DestinoNotificacionService>();
builder.Services.AddScoped<IReceptoresRepository, ReceptoresRepository>();
builder.Services.AddScoped<IReceptoresService, ReceptoresService>();
builder.Services.AddScoped<IEnviosRepository, EnviosRepository>();
builder.Services.AddScoped<IEnviosService, EnviosService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddHostedService<EnvioCorreoBackgroundService>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
