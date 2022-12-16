namespace Univ_WebSite_Razor_Core_Login5.Pages.data
{
    public class Priz : IPriz
    {
        public int Sourakh1(string x)
        {
            if (x == "salam")
                return 1;
            else
                return 0;
        }

        public string Sourakh2(int x)
        {
            if (x == 10)
                return "ok";
            else
                return "no";
        }
    }
}
