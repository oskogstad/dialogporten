﻿using AutoMapper;

namespace Digdir.Domain.Dialogporten.Application.Common.Extensions;

internal static class MappingExpressionExtensions
{
    private static readonly Type GenericNullableType = typeof(Nullable<>);
    private static readonly List<Type> TypeOverrides = new()
    {
        typeof(string),
        typeof(Uri)
    };

    public static IMappingExpression<TSource, TDest> IgnoreComplexDestinationProperties<TSource, TDest>(
        this IMappingExpression<TSource, TDest> expression)
    {
        var complexProperties = typeof(TDest)
            .GetProperties()
            .Where(x => !x.PropertyType.IsSimple())
            .ToList();

        foreach (var complexProperty in complexProperties)
        {
            expression.ForMember(complexProperty.Name, opt => opt.Ignore());
        }

        return expression;
    }

    internal static bool IsSimple(this Type type)
    {
        if (type is null)
        {
            throw new ArgumentNullException(nameof(type));
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == GenericNullableType)
        {
            // nullable type, check if the nested type is simple.
            return type.GetGenericArguments()[0].IsSimple();
        }

        return type.IsValueType || TypeOverrides.Contains(type);
    }
}
