﻿using Digdir.Library.Entity.Abstractions;

namespace Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.DialogElements;

public class DialogElementUrl : IEntity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }

    public Uri Url { get; set; } = null!;
    public string? MimeType { get; set; }

    // === Dependent relationships ===
    public DialogElementUrlConsumerType.Enum ConsumerTypeId { get; set; }
    public DialogElementUrlConsumerType ConsumerType { get; set; } = null!;

    public Guid DialogElementId { get; set; }
    public DialogElement DialogElement { get; set; } = null!;
}
