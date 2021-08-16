using System;
using System.Net.Http;

using ConsoleConnectToApi;

swaggerClient client = new("https://localhost:44352/", new HttpClient());
var results = await client.WeatherForecastAsync();
foreach (var result in results)
{
    Console.WriteLine($"Summary: {result.Summary}");
}

