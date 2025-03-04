var builder = DistributedApplication.CreateBuilder(args);

var dbUser = builder.AddParameter("pg-username", "admin");
var dbPass = builder.AddParameter("pg-password", "admin");
var database = builder.AddPostgres("database", dbUser, dbPass, 5445);

var apiService = builder.AddProject<Projects.LearningManagementSystem_ApiService>("apiservice")
    .WaitFor(database);

builder.AddProject<Projects.LearningManagementSystem_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
