﻿using Digdir.Domain.Dialogporten.Application.Features.V1.Common.ReturnTypes;
using FastEndpoints;
using FluentValidation.Results;

namespace Digdir.Domain.Dialogporten.WebApi;

public static class EndpointExtensions
{
    public static Task BadRequestAsync(this IEndpoint ep, ValidationError failure, CancellationToken cancellationToken = default)
        => ep.BadRequestAsync(failure.Errors, cancellationToken);
    public static Task BadRequestAsync(this IEndpoint ep, IEnumerable<ValidationFailure> failures, CancellationToken cancellationToken = default)
        => ep.HttpContext.Response.SendErrorsAsync(failures.ToList() ?? new(), StatusCodes.Status400BadRequest, cancellation: cancellationToken);

    public static Task NotFoundAsync(this IEndpoint ep, EntityNotFound notFound, CancellationToken cancellationToken = default) 
        => ep.HttpContext.Response.SendErrorsAsync(
            notFound.ToValidationResults(), 
            StatusCodes.Status404NotFound, 
            cancellation: cancellationToken);

    //public static Task UnprocessableEntityAsync(this IEndpoint ep, EntityExists entityExists, CancellationToken cancellationToken = default)
    //    => ep.HttpContext.Response.SendErrorsAsync(
    //        new() { new ValidationFailure(entityExists.Name, entityExists.Message) },
    //        StatusCodes.Status422UnprocessableEntity,
    //        cancellation: cancellationToken);

    public static Task ConflictAsync(this IEndpoint ep, EntityExists entityExists, CancellationToken cancellationToken = default)
        => ep.HttpContext.Response.SendErrorsAsync(
            entityExists.ToValidationResults(),
            StatusCodes.Status409Conflict,
            cancellation: cancellationToken);
}