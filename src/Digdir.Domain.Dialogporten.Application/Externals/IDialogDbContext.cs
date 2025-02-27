﻿using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.Actions;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.Activities;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.DialogElements;
using Digdir.Domain.Dialogporten.Domain.Localizations;
using Digdir.Domain.Dialogporten.Domain.Outboxes;
using Digdir.Library.Entity.Abstractions.Features.Identifiable;
using Microsoft.EntityFrameworkCore;

namespace Digdir.Domain.Dialogporten.Application.Externals;

public interface IDialogDbContext
{
    DbSet<DialogEntity> Dialogs { get; }
    DbSet<Localization> Localizations { get; }
    DbSet<LocalizationSet> LocalizationSets { get; }
    DbSet<DialogStatus> DialogStatuses { get; }
    DbSet<DialogActivity> DialogActivities { get; }
    DbSet<DialogApiAction> DialogApiActions { get; }
    DbSet<DialogApiActionEndpoint> DialogApiActionEndpoints { get; }
    DbSet<DialogGuiAction> DialogGuiActions { get; }
    DbSet<DialogElement> DialogElements { get; }
    DbSet<DialogElementUrl> DialogElementUrls { get; }
    DbSet<DialogGuiActionPriority> DialogGuiActionTypes { get; }
    DbSet<DialogActivityType> DialogActivityTypes { get; }

    DbSet<OutboxMessage> OutboxMessages { get; }
    DbSet<OutboxMessageConsumer> OutboxMessageConsumers { get; }

    Task<List<Guid>> GetExistingIds<TEntity>(
        IEnumerable<TEntity> entities, 
        CancellationToken cancellationToken) 
        where TEntity : class, IIdentifiableEntity;
}
