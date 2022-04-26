using DesignPatterns.Factory.Base;
using System;

namespace DesignPatterns.Factory.IOS
{
    class IOSUiTheme : Theme
    {
        public override IThemeComponentFactory GetComponentFactory()
        {
            return new IOSThemeComponentFactory();
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
