using System.Reflection;
using AutoMapper;

namespace Infrastructure.Mappings;

public static class AutoMapperExtension
{
    public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>
        (this IMappingExpression<TSource, TDestination> expression)
    {
        const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
        var sourceType = typeof(TSource);
        var destinationProperties = typeof(TDestination).GetProperties(flags);

        foreach (var property in destinationProperties)
            if (sourceType.GetProperty(property.Name, flags) == null)
                expression.ForMember(property.Name, opt => opt.Ignore());
        return expression;
    }
}