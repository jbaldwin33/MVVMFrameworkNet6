using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Resources;
using MVVMFramework;
using MVVMFramework.Localization;

namespace TranslatableAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = TranslatableClass.Instance;
            instance.AddToLocalizationFile();
            //ResourceManager MyResourceClass = new ResourceManager(typeof(Translatables));

            //ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CreateSpecificCulture("ja-JP"), true, true);
            //var newFile = File.Create("C:\\Users\\Josh\\VSProjects\\MVVMFramework\\translatables.txt");
            //using var sw = new StreamWriter(newFile);

            //foreach (DictionaryEntry entry in resourceSet)
            //{
            //    string resourceKey = $"{entry.Key}Translatable";
            //    object resource = entry.Value;


            //    sw.WriteLine($"public class {resourceKey} : Translatable");
            //    sw.WriteLine("{");
            //    sw.WriteLine(@$"public {resourceKey}(params object[] parameters) : base(parameters) {{ }}");
            //    sw.WriteLine($"protected override string GetDefaultTranslation() => \"{resource}\";");
            //    sw.WriteLine("}");

            //}
        }
    }
}
