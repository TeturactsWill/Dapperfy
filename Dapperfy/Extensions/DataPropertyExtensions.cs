namespace Dapperfy.Extensions
{
    using System;

    using Expression;

    internal static class DataPropertyExtensions
    {

        public static bool IsRelational(this DataProperty property)
        {
            var type = property.Value?.GetType();

            if (type == null)
                return false;

            switch (property.Value)
            {
                case byte[] ba:
                case string str:
                case byte b:
                case short s:
                case int i:
                case long l:
                case decimal d:
                case float f:
                case char c:
                case sbyte sb:
                case ulong ul:
                case uint ui:
                case ushort ss:
                case bool bl:
                case Guid g:
                case TimeSpan ts:
                case DateTime dt:
                    return false;
            }

            //// Check if it's a collection type, if it is, and 
            //// wrapped type is not primitive/enum/string return true
            //var info = type.GetTypeInfo();
            
            //if (info.ImplementedInterfaces.Any(i => i.Name == "IEnumerable"))
            //{
            //    var enumerableType = info.ImplementedInterfaces.FirstOrDefault(t => t.Name == "IEnumerable" && t.GetTypeInfo().IsGenericType);

            //    if (enumerableType != null 
            //        && enumerableType.GetTypeInfo().GenericTypeArguments[0].GetTypeInfo().IsPrimitive)
            //        return false;
            //}

            return true;
        }
    }
}
