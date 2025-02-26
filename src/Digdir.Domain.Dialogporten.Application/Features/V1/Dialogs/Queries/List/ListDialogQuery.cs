﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Digdir.Domain.Dialogporten.Application.Common.Pagination;
using Digdir.Domain.Dialogporten.Application.Externals;
using Digdir.Domain.Dialogporten.Application.Features.V1.Common.ReturnTypes;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OneOf;

namespace Digdir.Domain.Dialogporten.Application.Features.V1.Dialogs.Queries.List;

public sealed class ListDialogQuery : DefaultPaginationParameter, IRequest<OneOf<PaginatedList<ListDialogDto>, ValidationError>> { }

internal sealed class ListDialogQueryHandler : IRequestHandler<ListDialogQuery, OneOf<PaginatedList<ListDialogDto>, ValidationError>>
{
    private readonly IDialogDbContext _db;
    private readonly IMapper _mapper;

    public ListDialogQueryHandler(IDialogDbContext db, IMapper mapper)
    {
        _db = db ?? throw new ArgumentNullException(nameof(db));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    public async Task<OneOf<PaginatedList<ListDialogDto>, ValidationError>> Handle(ListDialogQuery request, CancellationToken cancellationToken)
    {
        return await _db.Dialogs
            .AsNoTracking()
            .OrderByDescending(x => x.CreatedAt)
            .ProjectTo<ListDialogDto>(_mapper.ConfigurationProvider)
            .ToPaginatedListAsync(request, cancellationToken);
    }
}
