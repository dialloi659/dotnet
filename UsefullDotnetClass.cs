namespace UsefullDotnetClass;

// How to create configuration and set JsonFile for appsettings, How to create configuration class
IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("AppSettings.json");
IConfiguration configuration = configurationBuilder.Build();