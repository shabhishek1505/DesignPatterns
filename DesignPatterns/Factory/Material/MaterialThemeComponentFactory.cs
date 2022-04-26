using DesignPatterns.Factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Material
{
    class MaterialThemeComponentFactory : IThemeComponentFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public IDropDown CreateDropDown()
        {
            return new MaterialDropDown();
        }

        public IMenu CreateMenu()
        {
            return new MaterialMenu();
        }
    }
}
