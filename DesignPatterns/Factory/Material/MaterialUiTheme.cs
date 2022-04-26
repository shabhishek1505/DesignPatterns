using DesignPatterns.Factory.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.Material
{
    class MaterialUiTheme : Theme
    {
        public override IThemeComponentFactory GetComponentFactory()
        {
            return new MaterialThemeComponentFactory();
        }

        public override string GetDetails()
        {
            throw new NotImplementedException();
        }

        public override string GetVersion()
        {
            throw new NotImplementedException();
        }
    }
}
