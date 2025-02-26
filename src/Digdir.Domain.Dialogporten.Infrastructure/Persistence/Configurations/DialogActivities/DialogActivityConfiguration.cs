﻿using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities.Activities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digdir.Domain.Dialogporten.Infrastructure.Persistence.Configurations.DialogActivities;

internal sealed class DialogActivityConfiguration : IEntityTypeConfiguration<DialogActivity>
{
    public void Configure(EntityTypeBuilder<DialogActivity> builder)
    {
        builder.HasOne(x => x.RelatedActivity)
            .WithMany(x => x.RelatedActivities)
            .OnDelete(DeleteBehavior.SetNull);
        builder.HasOne(x => x.DialogElement)
            .WithMany(x => x.Activities)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
