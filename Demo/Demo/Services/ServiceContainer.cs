using System;
using System.Collections.Generic;

namespace Demo.Services
{
    public class ServiceContainer
    {
        private static readonly Dictionary<Type, Lazy<object>> Services = new Dictionary<Type, Lazy<object>>();

        public static void Register<T>(Func<T> function)
        {
            Services[typeof(T)] = new Lazy<object>(() => function());
        }

        public static T Resolution<T>()
        {
            return (T)Resolution(typeof(T));
        }

        public static object Resolution(Type type)
        {
            if (Services.TryGetValue(type, out Lazy<object> service))
            {
                return service.Value;
            }

            throw new KeyNotFoundException($"Service not found for type '{type}'");
        }
    }
}
