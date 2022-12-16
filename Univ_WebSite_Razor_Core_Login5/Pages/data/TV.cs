namespace Univ_WebSite_Razor_Core_Login5.Pages.data
{
    public class TV
    {
        IPriz _ipriz;
        public TV(IPriz ipriz)
        {
            _ipriz = ipriz;
        }

        public string  m1()
        {
            string result = "";
           int number = _ipriz.Sourakh1("salam");
           string txt = _ipriz.Sourakh2(10);

            result = number.ToString() + "   " + txt;

            return result;

        }
    }
}
