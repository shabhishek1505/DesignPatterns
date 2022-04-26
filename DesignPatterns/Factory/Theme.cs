using DesignPatterns.Factory.Base;

namespace DesignPatterns.Factory
{
    public abstract class Theme
    {

        public string Name;
        public string AuthorName;

        public abstract string GetDetails();


        public abstract string GetVersion();

        //Factory Method
        public abstract IThemeComponentFactory GetComponentFactory();
    }

}
