using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FaceitFinderAPI
{
    public class FaceitFinder
    {
        public Responce GetResponce(string steam_id)
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();

                // Отправляем запрос.
                HttpResponse response = request.Get("https://faceitfinder.com/profile/" + steam_id);
                // Принимаем тело сообщения в виде строки.
                string site = response.ToString();
                Responce responce = new Responce();
                try
                {
                    responce.Faceit = new Uri(Regex.Match(site, "<a target=\"_blank\" class=\"nolink\" href=\"(.*)\" rel=\"noopener\"><img class=\"account-faceit-flag\"").Groups[1].Value);
                } catch { }
                responce.Trust = double.Parse(Regex.Match(site, "<div class=\"steam-trust-progress-red\" style=\"width:(.*)%\"></div><div class=\"steam-trust-defaultprogress\"").Groups[1].Value.Replace(".", ","));
                return responce;
            }
        }
        public class Responce
        {
            public double Trust;

            public Uri Faceit;
        }
    }
}
