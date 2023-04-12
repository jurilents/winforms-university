using System.Reflection;

namespace JustReflectionLab7
{
    public static class ReflectionExtensions
    {
        public static readonly List<AccessModifier> AccessModifiers = new List<AccessModifier>
        {
            AccessModifier.Private,
            AccessModifier.Protected,
            AccessModifier.ProtectedInternal,
            AccessModifier.Internal,
            AccessModifier.Public
        };

        public static string GetAccessModifierName(this PropertyInfo propertyInfo)
        {
            return propertyInfo.GetAccessModifier().ToString().ToLower();
        }

        public static string GetAccessModifierName(this MethodInfo methodInfo)
        {
            return methodInfo.GetAccessModifier().ToString().ToLower();
        }

        public static string GetAccessModifierName(this ConstructorInfo constructorInfo)
        {
            return constructorInfo.GetAccessModifier().ToString().ToLower();
        }

        public static AccessModifier GetAccessModifier(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.SetMethod == null)
                return propertyInfo.GetMethod.GetAccessModifier();
            if (propertyInfo.GetMethod == null)
                return propertyInfo.SetMethod.GetAccessModifier();
            var max = Math.Max(AccessModifiers.IndexOf(propertyInfo.GetMethod.GetAccessModifier()),
                AccessModifiers.IndexOf(propertyInfo.SetMethod.GetAccessModifier()));
            return AccessModifiers[max];
        }

        public static AccessModifier GetAccessModifier(this MethodInfo methodInfo)
        {
            if (methodInfo.IsPrivate)
                return AccessModifier.Private;
            if (methodInfo.IsFamily)
                return AccessModifier.Protected;
            if (methodInfo.IsFamilyOrAssembly)
                return AccessModifier.ProtectedInternal;
            if (methodInfo.IsAssembly)
                return AccessModifier.Internal;
            if (methodInfo.IsPublic)
                return AccessModifier.Public;
            throw new ArgumentException("Did not find access modifier", "methodInfo");
        }

        public static AccessModifier GetAccessModifier(this ConstructorInfo constructorInfo)
        {
            if (constructorInfo.IsPrivate)
                return AccessModifier.Private;
            if (constructorInfo.IsFamily)
                return AccessModifier.Protected;
            if (constructorInfo.IsFamilyOrAssembly)
                return AccessModifier.ProtectedInternal;
            if (constructorInfo.IsAssembly)
                return AccessModifier.Internal;
            if (constructorInfo.IsPublic)
                return AccessModifier.Public;
            throw new ArgumentException("Did not find access modifier", "methodInfo");
        }
    }

    public enum AccessModifier
    {
        Private,
        Protected,
        ProtectedInternal,
        Internal,
        Public
    }
}
