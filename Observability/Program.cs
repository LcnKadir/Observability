// See https://aka.ms/new-console-template for more information
using Observability;
using OpenTelemetry;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

Console.WriteLine("Hello, World!");

var traceProvider = Sdk.CreateTracerProviderBuilder()
    .AddSource(OpenTelemetryConstants.ActivitySourceName)
    .ConfigureResource(configure =>
    {
        configure
        .AddService(OpenTelemetryConstants.ServiceName, OpenTelemetryConstants.ServiceVersion)
        .AddAttributes(new List<KeyValuePair<string, object>>()
                {
                    new KeyValuePair<string, object>("host.machineName", Environment.MachineName),
                    new KeyValuePair<string, object>("host.enviroment", "dev"),
                });
    }).AddConsoleExporter().Build();

var serciceHelper = new ServiceHelper();
serciceHelper.Work1();
