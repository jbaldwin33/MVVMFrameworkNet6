using MVVMFramework.Localization;

namespace TranslatableAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = TranslatableClass.Instance;
            instance.AddToLocalizationFile();
        }
    }
}
