

namespace DesignPatterns.Factory.Base
{
    public interface IThemeComponentFactory
    {
        IButton CreateButton();
        IMenu CreateMenu();
        IDropDown CreateDropDown();
    }
}
