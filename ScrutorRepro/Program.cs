using Microsoft.Extensions.DependencyInjection;
using Scrutor.Repro;

IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection.AutoRegister();
Console.WriteLine($"My service collection has {serviceCollection.Count} entries.");
Console.WriteLine(serviceCollection.BuildServiceProvider().GetService<ISayHelloToTheWorld>()!.Speak());