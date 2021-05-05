using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using Ies.Logo.DataType.Infrastructure;
using Ies.Logo.DataType.Xml.Converters;

namespace Ies.Logo.DataType.Xml
{
    internal static class Serializer
    {
        public static XmlWriterSettings XmlWriterSetting { get; set; } = new XmlWriterSettings
        {
            Indent = true
        };
        private static IList<Assembly> ReferencedAssemblies { get; } = GetReferencedAssemblies();
        private static Dictionary<Type, IExtendedXmlSerializer> Serializers { get; } = CreateSerializers();

        private static IList<Assembly> GetReferencedAssemblies()
        {
            var assembyList = AppDomain.CurrentDomain.GetAssemblies()
                                                     .Where(x => x.GetReferencedAssemblies().Any(a => a.Name == Assembly.GetExecutingAssembly().GetName().Name))
                                                     .ToList();
            assembyList.Insert(0, Assembly.GetExecutingAssembly());

            return assembyList;
        }

        #region SerializerInstance
        public static IExtendedXmlSerializer Get<T>() => Serializers[typeof(T)];
        private static Dictionary<Type, IExtendedXmlSerializer> CreateSerializers()
        {
            var serializers = new Dictionary<Type, IExtendedXmlSerializer>();

            CreateSerializers(serializers);

            return serializers;
        }
        private static void CreateSerializers(Dictionary<Type, IExtendedXmlSerializer> dictionaries)
        {
            foreach (Type logoBaseType in ReferencedAssemblies.SelectMany(a => a.GetTypes().Where(w => typeof(ILogoBase).IsAssignableFrom(w) && !w.IsAbstract)))
            {
                var subClasses = new HashSet<Type>(logoBaseType
                                     .GetProperties()
                                     .Select(t => t.PropertyType.IsGenericType ? t.PropertyType.GetGenericArguments().FirstOrDefault() : t.PropertyType)
                                     .Where(p => p != typeof(string) && p.IsClass)
                                     );
                TypeLoop(subClasses).ForEach(f => subClasses.Add(f));
                subClasses.Add(logoBaseType);
                subClasses.Add(typeof(List<>).MakeGenericType(logoBaseType));

                var serializer = Serializer.CreateConfiguration().EnableImplicitTyping(subClasses).Create();
                dictionaries.Add(logoBaseType, serializer);
                dictionaries.Add(typeof(List<>).MakeGenericType(logoBaseType), serializer);
            }
        }
        private static HashSet<Type> TypeLoop(HashSet<Type> loopTypes)
        {
            HashSet<Type> mustAddedTypes = new HashSet<Type>();

            foreach (var type in loopTypes)
            {
                var subTypes = new HashSet<Type>(type.GetProperties()
                                   .Select(t => t.PropertyType.IsGenericType ? t.PropertyType.GetGenericArguments().FirstOrDefault() : t.PropertyType)
                                   .Where(p => p != typeof(string) && p.IsClass)
                                   );

                if (subTypes.Count > 0)
                    TypeLoop(subTypes).ForEach(f => mustAddedTypes.Add(f)); 
                
                mustAddedTypes.Add(type);
            }
            return mustAddedTypes;
        }
        #endregion

        #region Configuration
        public static IConfigurationContainer CreateConfiguration()
        {
            var configuration = new ConfigurationContainer();

            Configure(configuration);

            return configuration;
        }
        public static void Configure(IConfigurationContainer configuration)
        {
            configuration.Type<DateTime>().Register().Converter().Using(DateTimeConverter.Default);

            configuration.Ignore(typeof(List<>).GetProperty(nameof(List<object>.Capacity)));

            configuration.SetMapping();
        }
        private static void SetMapping(this IConfigurationContainer configuration)
        {
            foreach (var type in ReferencedAssemblies.SelectMany(a => a.GetTypes().Where(x => typeof(IConfigurationProfile).IsAssignableFrom(x))))
            {
                MethodInfo method = typeof(ExtensionMethodsForConfiguration).GetMethod(nameof(ExtensionMethodsForConfiguration.Configured));
                MethodInfo generic = method.MakeGenericMethod(type);
                generic.Invoke(null, new object[] { configuration });
            }
        }
        #endregion

        public static string Serialize<T>(this T data)
        {
            string xml;
            var serializer = Get<T>();
            lock (serializer)
            {
                xml = serializer.Serialize(XmlWriterSetting, data);
            }

            if (xml.IndexOf(" xmlns") > 0)
                xml = xml.Replace(xml.Substring(xml.IndexOf(" xmlns"), xml.IndexOf("\">") + 1 - xml.IndexOf(" xmlns")), "")
                         .Replace("utf-8", "ISO-8859-9")
                         .Replace(" exs:member=\"\"", "")
                         ;

            return xml;
        }
    }
}
