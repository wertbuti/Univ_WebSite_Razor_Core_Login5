namespace Univ_WebSite_Razor_Core_Login5.Pages.data
{
    public class Priz2 : IPriz
    {
        public int Sourakh1(string x)
        {
            if (x == "salam")
                return 1000;
            else
                return 40;
        }

        public string Sourakh2(int x)
        {
            if (x == 10)
                return "noooooooo";
            else
                return "Areee";
        }
    }
}
