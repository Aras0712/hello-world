using System.Globalization;

namespace hello_world
{
    public class CapitalizeHello
    {
        TextInfo HelloW = new CultureInfo("en-US",false).TextInfo;
        public string Lower(string name)
        {
          return (HelloW.ToTitleCase(name.ToLower()));
        }
    }
}
