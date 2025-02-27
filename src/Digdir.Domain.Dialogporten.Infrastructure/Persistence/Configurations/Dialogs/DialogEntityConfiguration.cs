﻿using Digdir.Domain.Dialogporten.Domain.Common;
using Digdir.Domain.Dialogporten.Domain.Dialogs.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digdir.Domain.Dialogporten.Infrastructure.Persistence.Configurations.Dialogs;

internal sealed class DialogEntityConfiguration : IEntityTypeConfiguration<DialogEntity>
{
    public void Configure(EntityTypeBuilder<DialogEntity> builder)
    {
        builder.ToTable("Dialog");
        builder.Property(x => x.ServiceResource)
            .HasMaxLength(Constants.DefaultMaxStringLength);
    }
}
