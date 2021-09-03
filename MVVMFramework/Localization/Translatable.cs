using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MVVMFramework.Localization
{
    public abstract class Translatable
    {
        private readonly object[] parameters;
        private readonly TranslatableClass localizationCache;

        //static Translatable()
        //{
        //}

        //protected Translatable()
        //{
        //    localizationCache.AddToLocalizationFile(this);
        //}
        
        protected Translatable(params object[] args)
        {
            parameters = args;
            localizationCache = TranslatableClass.Instance;
        }

        protected abstract string GetDefaultTranslation();

        public override string ToString()
        {
            var s = string.Format(GetTranslation(), parameters);
            return s;
        }

        public static implicit operator string(Translatable translatable) => translatable.ToString();

        public string GetTranslation()
        {
            var translation = GetDefaultTranslation();
            var elements = localizationCache.LocalizationFile.Items.Where(translatableElement => translatableElement.Name == GetType().FullName);
            foreach (var translatableElement in elements)
                translation = translatableElement.Items.First(x => int.Parse(x.LCID) == x.LCIDArray.First(lcid => lcid == localizationCache.CurrentLCID)).Text;
            return translation;
        }

    }
}
