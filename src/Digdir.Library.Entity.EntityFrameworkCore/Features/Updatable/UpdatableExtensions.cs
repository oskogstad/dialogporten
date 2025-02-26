﻿using Digdir.Library.Entity.Abstractions.Features.Updatable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Digdir.Library.Entity.EntityFrameworkCore.Features.Updatable;

internal static class UpdatableExtensions
{
    public static ModelBuilder AddUpdatableEntities(this ModelBuilder modelBuilder)
    {
        return modelBuilder.EntitiesOfType<IUpdateableEntity>(builder =>
            builder.Property(nameof(IUpdateableEntity.UpdatedAt)).HasDefaultValueSql("current_timestamp at time zone 'utc'"));
    }

    public static ChangeTracker HandleUpdatableEntities(this ChangeTracker changeTracker, DateTimeOffset utcNow)
    {
        var updatableEntities = changeTracker
            .Entries<IUpdateableEntity>()
            .Where(x => x.State is EntityState.Added or EntityState.Modified);

        foreach (var entity in updatableEntities)
        {
            entity.Entity.Update(utcNow);
        }

        return changeTracker;
    }
}
