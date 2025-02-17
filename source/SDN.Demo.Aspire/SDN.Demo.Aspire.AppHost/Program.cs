using System.Collections.Immutable;
using Aspire.Hosting.Dapr;

var builder = DistributedApplication.CreateBuilder(args);

var daprComponentsFolder = new DirectoryInfo(
    Path.Combine(Directory.GetCurrentDirectory(),
        "..\\..\\..\\dapr\\components")
);
if (!daprComponentsFolder.Exists)
{
    throw new DirectoryNotFoundException(
        $"The Dapr components folder {daprComponentsFolder.FullName} does not exist.");
}

builder.AddDapr();
var options = new DaprSidecarOptions
{
    ResourcesPaths = ImmutableHashSet.Create(
        daprComponentsFolder.FullName)
};

builder.AddProject<Projects.SDN_Demo_Sender_Api>("sdn-demo-sender-api")
    .WithDaprSidecar(options);

builder.AddProject<Projects.SDN_Demo_Receiver_Api>("sdn-demo-receiver-api")
    .WithDaprSidecar(options);

builder.Build().Run();
