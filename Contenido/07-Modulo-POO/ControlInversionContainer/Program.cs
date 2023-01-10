using ControlInversionContainer.Controllers;
using ControlInversionContainer.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


// Configurando el contenedor de inversión de controles
var hostBuilder = Host.CreateDefaultBuilder(args);
hostBuilder = hostBuilder.ConfigureServices(ServicesConfiguration);
using var host = hostBuilder.Build();

void ServicesConfiguration(IServiceCollection services)
{
    // Transient: Solo queremos funcionalidad sin estado de los datos. Que solo viva en una instancea.
    // ¿Qué siginifica esto?
    // Cada vez que alguien necesite el service IStorageService, se le va a entregar una instancia de AzureStorageService
    services.AddTransient<IStorageService, AzureStorageService>();

    // Esto permite dos cosas:
    // 1. Centralización de la lógica de instanciación de ImageController.
    // 2. Cuando pida una instancea de ImageController, no solo se va a instanciar el controlador,
    // si no también todas sus depencencias se van a instanciar (Simepre y cuando estén configurados en el contenedor.
    services.AddTransient<ImageController>();

    services.AddTransient<OtherController>();
}

var imageController = host.Services.GetRequiredService<ImageController>();

var otherController = host.Services.GetRequiredService<OtherController>();

imageController.SaveImage();

otherController.SaveMyPdf();


// Este es un problema, que tal si necesitamos más instanceas imageController en otros lugares.
// Que tal si el día de mañana se necesita cambiar el porveedor de storage a AWS. Tendríamos
// que cambiarlo en los lugares donde implementamos la instancia ImageController.
//
// Es por ello que para solucionarlo ocupamos: Contenedor de inversión de controles. El cual,
// permite centralizar en un lugar la lógica de instanciar todas las clases y suplir todas sus
// dependencias.
//
// var imageController = new ImageController(azureStorageService);