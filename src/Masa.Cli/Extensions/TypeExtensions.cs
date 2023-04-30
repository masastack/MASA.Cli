namespace System
{
    public static class TypeExtensions
    {
        public static List<Type> GetChildClasses(this Type baseType, Assembly assembly = null)
        {

            if (assembly == null)
            {
                assembly = baseType.Assembly;
            }

            return assembly.GetTypes().Where(e => baseType.IsAssignableFrom(e) && !e.IsAbstract).ToList();
        }

        public static bool IsCommandName(this Type classType, string name, string ignoreSuffix = "Command")
        {
            string className = ignoreSuffix.IsNullOrEmpty() ? classType.Name : classType.Name.TrimEnd(ignoreSuffix);
            if (className.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            var displayNameAttr = classType.GetCustomAttribute<DisplayNameAttribute>();
            if (displayNameAttr != null && displayNameAttr.DisplayName.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

        public static string GetCommandName(this Type classType, string ignoreSuffix = "Command")
        {
            var displayNameAttr = classType.GetCustomAttribute<DisplayNameAttribute>();
            if (displayNameAttr != null)
            {
                return displayNameAttr.DisplayName;
            }

            return classType.Name.TrimEnd(ignoreSuffix);
        }
    }
}
