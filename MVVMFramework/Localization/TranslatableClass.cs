using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace MVVMFramework.Localization
{
    public class TranslatableClass
    {
        private static readonly Lazy<TranslatableClass> lazy = new Lazy<TranslatableClass>(() => new TranslatableClass());
        public static TranslatableClass Instance => lazy.Value;
        public LocalizationClass LocalizationFile;
        public int PreferredLCID;
        public int CurrentLCID;
        private static XmlSerializer _xmlSerializer;
        private static XmlSerializer xmlSerializer => _xmlSerializer ?? (_xmlSerializer = new XmlSerializer(typeof(LocalizationClass)));
        private static string localizationPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Localization", "Localization.xml");
        private static string masterLocalizationPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "VSProjects", "MVVMFramework", "Localization", "Localization.xml");
        private TranslatableClass()
        {
            if (string.IsNullOrEmpty(localizationPath))
                throw new Exception("Cannot read 'binaryFolder' variable from app.config / web.config.");

            using (var reader = new StreamReader(localizationPath))
                LocalizationFile = (LocalizationClass)xmlSerializer.Deserialize(reader);
            PreferredLCID = LocalizationFile.PreferredLCID;
            CurrentLCID = CultureInfo.CurrentUICulture.LCID;
        }

        public void AddToLocalizationFile()
        {
            //ResourceManager MyResourceClass = new ResourceManager(typeof(Translatables));

            //ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CreateSpecificCulture("ja-JP"), true, true);
            
            


            var translatables = ReflectiveEnumerator.GetEnumerableOfType<Translatable>();
            foreach (var translatable in translatables)
            {
                if (LocalizationFile.Items.Any(i => i.Name == translatable.GetType().FullName))
                    continue;
                var resourceName = translatable.GetType().Name.Substring(0, translatable.GetType().Name.Length - 12);
                LocalizationFile.Items.Add(new LocalizationClass.TranslatableElement
                {
                    Name = translatable.GetType().FullName,
                    Items = new[]
                    {
                        new LocalizationClass.TranslatableElement.Translation
                        {
                            Text = translatable.GetTranslation(),
                            LCIDArray = new[] { 1033 }
                        },
                        //new LocalizationClass.TranslatableElement.Translation
                        //{
                        //    Text = resourceSet.GetString(resourceName),
                        //    LCIDArray = new []{ 1041}
                        //}
                    }
                });
            }

            SaveFile();
        }

        private void SaveFile()
        {
            using (var stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, LocalizationFile);
                File.WriteAllText(localizationPath, stringWriter.ToString(), Encoding.Unicode);
                File.WriteAllText(masterLocalizationPath, stringWriter.ToString(), Encoding.Unicode);
            }
        }

        public IEnumerable<Type> FindSubClassesOf<TBaseType>()
        {
            var assemblyName = Assembly.GetExecutingAssembly();

            Type[] types;
            try
            {
                types = assemblyName.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                types = e.Types;
            }

            return types.Where(t => t != null && t.IsSubclassOf(typeof(TBaseType)));
        }
    }

    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
        {
            Type[] types;
            List<T> objects = new List<T>();
            try
            {
                types = Assembly.GetAssembly(typeof(T)).GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                types = e.Types;
            }

            var newTypes = types.Where(myType => myType != null && myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));
            foreach (var type in newTypes)
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            return objects;
        }
    }
}
