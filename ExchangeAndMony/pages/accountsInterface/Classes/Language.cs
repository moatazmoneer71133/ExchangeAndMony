using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeAndMony.pages.accountsInterface.Classes
{
    class Language
    {

       public void englishLanguage()
        {
            var lang = InputLanguage.InstalledInputLanguages.OfType<InputLanguage>().Where(l => l.Culture.Name.StartsWith("en")).FirstOrDefault();
            if (lang != null)
            {
                InputLanguage.CurrentInputLanguage = lang;
            }
        }


        public void arabicLanguage()
        {
            var lang = InputLanguage.InstalledInputLanguages.OfType<InputLanguage>().Where(l => l.Culture.Name.StartsWith("ar")).FirstOrDefault();
            if (lang != null)
            {
                InputLanguage.CurrentInputLanguage = lang;
            }
        }
    }
}
