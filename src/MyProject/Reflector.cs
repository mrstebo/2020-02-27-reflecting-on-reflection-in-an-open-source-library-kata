using System;

namespace MyProject
{
    public static class Reflector
    {
        public static T GetPropertyValue<T>(object obj, string propertyName)
        {
            return default(T);
        }

        public static T InvokeMethod<T>(object obj, string methodName)
        {
            return default(T);
        }

        public static string GetBaseClassName(object obj)
        {
            return null;
        }
    }
}