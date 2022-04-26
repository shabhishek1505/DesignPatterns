using DesignPatterns.Factory.IOS;
using DesignPatterns.Factory.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    static class Client
    {
        readonly static string _theme = "IOS";
        public static void Execute()
        {
           
            var theme = ThemeFactory.GetTheme(_theme);

            var themeComponentFac=theme.GetComponentFactory();

            themeComponentFac.CreateButton();

        }
    }
}
