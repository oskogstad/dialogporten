﻿using Digdir.Domain.Dialogporten.Application.Features.V1.Common.Localizations;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.Actions;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.Activities;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.DialogElements;
using Digdir.Domain.Dialogporten.Domain.Http;

namespace Digdir.Domain.Dialogporten.Application.Features.V1.Dialogs.Queries.Get;

public sealed class GetDialogDto
{
    public Guid Id { get; set; }
    public string Org { get; set; } = null!;
    public Uri ServiceResource { get; set; } = null!;
    public string Party { get; set; } = null!;
    public string? ExtendedStatus { get; set; }
    public DateTimeOffset? VisibleFrom { get; set; }
    public DateTimeOffset? DueAt { get; set; }
    public DateTimeOffset? ExpiresAt { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
    public DateTimeOffset? ReadAt { get; set; }

    public DialogStatus.Enum Status { get; set; }

    public List<LocalizationDto> Body { get; set; } = new();
    public List<LocalizationDto> Title { get; set; } = new();
    public List<LocalizationDto> SenderName { get; set; } = new();
    public List<LocalizationDto> SearchTitle { get; set; } = new();

    public List<GetDialogDialogElementDto> Elements { get; set; } = new();
    public List<GetDialogDialogGuiActionDto> GuiActions { get; set; } = new();
    public List<GetDialogDialogApiActionDto> ApiActions { get; set; } = new();
    public List<GetDialogDialogActivityDto> Activities { get; set; } = new();
}

public sealed class GetDialogDialogActivityDto
{
    public Guid Id { get; set; }
    public DateTimeOffset? CreatedAt { get; set; }
    public Uri? ExtendedType { get; set; }

    public DialogActivityType.Enum Type { get; set; }

    public Guid? RelatedActivityId { get; set; }
    public Guid? DialogElementId { get; set; }

    public List<LocalizationDto>? PerformedBy { get; set; } = new();
    public List<LocalizationDto> Description { get; set; } = new();
}

public sealed class GetDialogDialogApiActionDto
{
    public Guid Id { get; set; }
    public string Action { get; set; } = null!;
    public string? AuthorizationAttribute { get; set; }

    public Guid? DialogElementId { get; set; }

    public List<GetDialogDialogApiActionEndpointDto> Endpoints { get; set; } = new();
}

public sealed class GetDialogDialogApiActionEndpointDto
{
    public Guid Id { get; set; }
    public string? Version { get; set; }
    public Uri Url { get; set; } = null!;
    public HttpVerb.Enum HttpMethod { get; set; }
    public Uri? DocumentationUrl { get; set; }
    public Uri? RequestSchema { get; set; }
    public Uri? ResponseSchema { get; set; }
    public bool Deprecated { get; set; }
    public DateTimeOffset? SunsetAt { get; set; }
}

public sealed class GetDialogDialogGuiActionDto
{
    public Guid Id { get; set; }
    public string Action { get; set; } = null!;
    public Uri Url { get; set; } = null!;
    public string? AuthorizationAttribute { get; set; }
    public bool IsBackChannel { get; set; }
    public bool IsDeleteAction { get; set; }

    public DialogGuiActionPriority.Enum Priority { get; set; }

    public List<LocalizationDto> Title { get; set; } = new();
}

public sealed class GetDialogDialogElementDto
{
    public Guid Id { get; set; }
    public Uri? Type { get; set; }
    public string? AuthorizationAttribute { get; set; }

    public Guid? RelatedDialogElementId { get; set; }

    public List<LocalizationDto> DisplayName { get; set; } = new();
    public List<GetDialogDialogElementUrlDto> Urls { get; set; } = new();
}

public sealed class GetDialogDialogElementUrlDto
{
    public Guid Id { get; set; }
    public Uri Url { get; set; } = null!;
    public string? MimeType { get; set; }

    public DialogElementUrlConsumerType.Enum ConsumerType { get; set; }
}
