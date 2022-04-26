using DesignPatterns.Factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.IOS
{
    class IOSThemeComponentFactory : IThemeComponentFactory
    {
        public IButton CreateButton()
        {
            return new IOSButton();
        }

        public IDropDown CreateDropDown()
        {
            return new IOSDropDown();
        }

        public IMenu CreateMenu()
        {
            return new IOSMenu();
        }
    }
}
