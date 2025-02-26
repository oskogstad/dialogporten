﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Digdir.Domain.Dialogporten.WebApi.Common;

/// <summary>
/// This is a workaround to support JSON patch through NewtonsoftJson while still using System.Text.Json for everything else.
/// See https://learn.microsoft.com/en-us/aspnet/core/web-api/jsonpatch?view=aspnetcore-7.0
/// </summary>
internal static class JsonPatchInputFormatter
{
    public static NewtonsoftJsonPatchInputFormatter Get()
    {
        return new ServiceCollection()
            .AddLogging()
            .AddMvc()
            .AddNewtonsoftJson()
            .Services.BuildServiceProvider()
            .GetRequiredService<IOptions<MvcOptions>>()
            .Value
            .InputFormatters
            .OfType<NewtonsoftJsonPatchInputFormatter>()
            .First();
    }
}