using DesignPatterns.Factory.IOS;
using DesignPatterns.Factory.Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    static class ThemeFactory
    {
        //Simple Factory
        public static Theme GetTheme(string theme)
        {
            Theme instance;
            if (theme == "IOS")
            {
                instance = new IOSUiTheme();
            }
            else
            {
                instance = new MaterialUiTheme();
            }

            return instance;

        }

    }
}
