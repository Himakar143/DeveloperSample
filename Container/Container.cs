using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly Dictionary<Type, Type> serviceMap;

        public Container()
        {
            serviceMap = new Dictionary<Type, Type>();
        }

        public void Bind(Type interfaceType, Type implementationType)
        {
            if (interfaceType?.IsInterface != true)
                throw new ArgumentException("First type must be a valid interface");

            if (implementationType?.IsClass != true)
                throw new ArgumentException("Second type must be a valid class");

            if (!interfaceType.IsAssignableFrom(implementationType))
                throw new ArgumentException($"Type {implementationType.Name} must implement interface {interfaceType.Name}");

            serviceMap.Add(interfaceType, implementationType);
        }

        public T Get<T>()
        {
            var interfaceType = typeof(T);

            if (!serviceMap.TryGetValue(interfaceType, out var implType))
            {
                throw new Exception($"No binding for {interfaceType.Name}");
            }

            var instance = Activator.CreateInstance(implType);
            return (T)instance;
        }
    }
}