var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.LearningManagementSystem_ApiService>("apiservice");

builder.AddProject<Projects.LearningManagementSystem_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
