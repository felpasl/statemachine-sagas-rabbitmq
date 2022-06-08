﻿using Microsoft.Extensions.Hosting;
using Samples.Sagas.ProcessLine.Service.Injection;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(s => s.ConfigureQueue())
    .Build();

await host.RunAsync();